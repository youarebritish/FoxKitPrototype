using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using FoxKit.FormatHandlers;
using FoxKit.Framework.Concurrency;
using FoxKit.Utils;
using UnityEditor;
using UnityEngine;
using static System.Half;

namespace FoxKit.Framework.FormatHandlers.Model
{
    /// <summary>
    /// https://github.com/BobDoleOwndU/FMDL-Studio-v2/tree/master/FMDL-Studio-v2/Assets/Scripts/Data
    /// </summary>
    public class ModelHandler : IFoxAssetHandler
    {
        private static readonly List<string> DecompilableExtensions = new List<string>
        {
            "fmdl"
        };

        private readonly string assetPath;
        private readonly IUnityThreadCommandDispatcher unityThreadDispacher;

        public List<string> Extensions => DecompilableExtensions;

        public ModelHandler(string assetPath, IUnityThreadCommandDispatcher unityThreadDispacher)
        {
            this.assetPath = assetPath;
            this.unityThreadDispacher = unityThreadDispacher;
        }

        public void Export(object asset, string path)
        {
            throw new NotImplementedException();
        }

        public void Import(Stream input, string path)
        {
            var prefabPath = Path.GetDirectoryName(path) + "/" + Path.GetFileNameWithoutExtension(path) + ".prefab";
            if (File.Exists(prefabPath))
            {
                return;
            }

            try
            {
                var reader = new Fmdl();
                reader.Read(input);

                Directory.CreateDirectory(Path.GetDirectoryName(Directory.GetParent(assetPath) + "/" + path));
                var createMeshCommand = new CreateMesh(() => reader.CreateAndSaveMesh(path));
                unityThreadDispacher.DispatchCommand(createMeshCommand);
            }
            catch (Exception e)
            {
                UnityEngine.Debug.LogError(e);
                throw;
            }
        }
        

    }
}