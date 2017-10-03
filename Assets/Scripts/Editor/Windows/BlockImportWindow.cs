using FoxKit.FormatHandlers.DataSet;
using FoxKit.Framework.Fox;
using FoxKit.Framework.Tpp.Classes;
using FoxTool.Fox;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FoxKit.FormatHandlers;
using FoxKit.FormatHandlers.Archive;
using FoxKit.FormatHandlers.LocatorArray;
using FoxKit.FormatHandlers.Script;
using FoxKit.Framework.Concurrency;
using FoxKit.Framework.FormatHandlers.Model;
using GzsTool.Core.Common;
using GzsTool.Core.Fpk;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FoxKit.Editor.Windows
{
    public class BlockImportWindow : EditorWindow
    {
        const string BlockControllerName = "Block Controller";
        static readonly IUnityThreadCommandDispatcher commandDispatcher = new UnityThreadCommandDispatcher();

        [MenuItem("FoxKit/Import Block...")]
        static void Init()
        {
            var path = EditorUtility.OpenFilePanel("Import New Block", "", "fpkd");
            if (path.Length == 0) return;
            GetEditorProgressBar();
            var window = (BlockImportWindow)GetWindow(typeof(BlockImportWindow));
            window.Show();

            //ShowProgressBar("Loading block", 0.64f);
            try
            {
                LoadBlock(path, commandDispatcher);
            }
            catch (Exception e)
            {
                Debug.LogError(e);
                throw;
            }
        }

        private static void LoadBlock(string blockPath, IUnityThreadCommandDispatcher commandDispatcher)
        {
            // Create scene to contain the new block.
            var newScene = CreateSceneForBlock();
            SceneManager.SetActiveScene(newScene);
            
            var relativePath = FindAssetsDirectory(blockPath);
            var scenePath = relativePath + "/" + Path.GetFileNameWithoutExtension(blockPath) + ".unity";

            Directory.CreateDirectory(Path.GetDirectoryName(scenePath));
            var blockController = InitializeScene(newScene, scenePath);

            // Read DataSet files.
            var assetPath = Application.dataPath;
            var formatHandlerProvider = MakeFormatHandlerProvider(assetPath, commandDispatcher);
            var task = new Task(
                delegate()
                {
                    LoadDataSets(formatHandlerProvider, blockPath);
                });
            task.Start();
        }

        private static string FindAssetsDirectory(string path)
        {
            var dir = new DirectoryInfo(path).Parent;
            var assetsDir = new StringBuilder();

            while (dir != null)
            {
                assetsDir.Insert(0, "/" + dir.Name);
                if (dir.Name == "Assets")
                {
                    break;
                }
                dir = dir.Parent;
            }
            // Remove leading slash.
            assetsDir.Remove(0, 1);
            return assetsDir.ToString();
        }

        private static void LoadDataSets(FormatHandlerProvider formatHandlerProvider, string blockPath)
        {
            var archiveHandler = new ArchiveHandler<FpkFile>();

            var fpkPath = blockPath.Substring(0, blockPath.Length - 1);
            var archives = new[] {fpkPath, blockPath};

            foreach (var archivePath in archives)
            {
                using (var input = new FileStream(archivePath, FileMode.Open))
                {
                    var archive = archiveHandler.Import(input, archivePath);
                    Parallel.ForEach(archive.ExportFiles(input),
                        delegate(FileDataStreamContainer container)
                        {
                            // Check if extension is supported.
                            if (!formatHandlerProvider.IsExtensionSupported(Path.GetExtension(container.FileName)
                                .Replace(".", ""))) return;

                            // Import the file.
                            using (var output = new MemoryStream())
                            {
                                container.DataStream().CopyTo(output);
                                output.Flush();
                                output.Seek(0, SeekOrigin.Begin);
                                formatHandlerProvider.Import(output, container.FileName);
                            }
                        });
                }
            }
        }
        
        private void Update()
        {
            commandDispatcher?.Update();
        }

        /// <summary>
        /// Creates a new scene into which we'll load the block.
        /// </summary>
        /// <returns></returns>
        private static Scene CreateSceneForBlock()
        {
            var newScene = EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Additive);
            return newScene;
        }

        /// <summary>
        /// Initializes the new scene.
        /// </summary>
        /// <param name="newScene"></param>
        /// <returns></returns>
        private static Block InitializeScene(Scene newScene, string newScenePath)
        {
            EditorSceneManager.SaveScene(newScene, newScenePath);
            Block blockController;
            {
                var blockGameObject = new UnityEngine.GameObject(BlockControllerName);
                blockController = blockGameObject.AddComponent<Block>();
                SceneManager.MoveGameObjectToScene(blockGameObject, newScene);
            }
            return blockController;
        }

        /// <summary>
        /// Get all Entity types.
        /// </summary>
        /// <returns>A look-up table of Entity types keyed by name.</returns>
        private static Dictionary<string, Type> MakeEntityTypeTable()
        {
            var results = new Dictionary<string, Type>();
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                var types = assembly.GetTypes();
                foreach (var type in types)
                {
                    if (type.IsSubclassOf(typeof(Entity)))
                    {
                        results.Add(type.Name, type);
                    }
                }
            }
            return results;
        }

        private static FormatHandlerProvider MakeFormatHandlerProvider(string assetPath, IUnityThreadCommandDispatcher dispatcher)
        {
            var unimplementedTypeTable = new ConcurrentDictionary<string, FoxEntity>();
            var handlers = new HashSet<IFoxAssetHandler>
            {
                // TODO ArchiveHandler
                new DataSetHandler(MakeEntityTypeTable(), unimplementedTypeTable, dispatcher),
                new LuaScriptHandler(assetPath),
                new ModelHandler(assetPath, dispatcher),
                //new LocatorArrayHandler(assetPath, dispatcher)
            };
            return new FormatHandlerProvider(handlers);
        }

        // Dumb hack stuff to hijack Unity's editor progress bar
        private static MethodInfo display;
        private static MethodInfo clear;

        static void GetEditorProgressBar()
        {
            var type = typeof(UnityEditor.Editor).Assembly.GetTypes().FirstOrDefault(t => t.Name == "AsyncProgressBar");
            if (type == null) return;

            display = type.GetMethod("Display");
            clear = type.GetMethod("Clear");
        }

        static void ShowProgressBar(string aText, float aProgress)
        {
            if (display != null)
                display.Invoke(null, new object[] { aText, aProgress });
        }

        static void ClearProgressBar()
        {
            if (clear != null)
                clear.Invoke(null, null);
        }
    }
}