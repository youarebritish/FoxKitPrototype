using System;
using System.Collections.Generic;
using System.IO;
using FoxKit.Framework.Concurrency;
using FoxKit.Framework.FormatHandlers.Model;
using UnityEditor;
using UnityEngine;

namespace FoxKit.FormatHandlers.LocatorArray
{
    /// <summary>
    /// Imports locator binary arrays (.lba).
    /// </summary>
    public class LocatorArrayHandler : IFoxAssetHandler
    {
        private static readonly List<string> DecompilableExtensions = new List<string>
        {
            "lba",
        };
        private readonly string assetPath;
        private readonly HashManager hashManager;
        private readonly IUnityThreadCommandDispatcher dispatcher;
        private readonly List<LocatorArray> locatorArrays = new List<LocatorArray>();

        public List<string> Extensions => DecompilableExtensions;

        public LocatorArrayHandler(string assetPath, IUnityThreadCommandDispatcher dispatcher)
        {
            this.assetPath = assetPath;
            hashManager = new HashManager(); // TODO Set up dict
            this.dispatcher = dispatcher;
        }

        public void Export(object asset, string path)
        {
            throw new NotImplementedException();
        }

        public void Import(Stream input, string path)
        {
            using (var reader = new BinaryReader(input))
            {
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(Directory.GetParent(assetPath) + "/" + path));

                    LocatorArray locatorArray = null;

                    var locatorCount = reader.ReadUInt32();
                    var type = (LocatorType)reader.ReadUInt32();

                    IUnityThreadCommand createLocatorArrayCommand = new CreateScriptableObject<LocatorArray>(path,
                        (createdLocatorArray) => locatorArray = createdLocatorArray);

                    var waitHandle = dispatcher.DispatchCommand(createLocatorArrayCommand);
                    waitHandle.WaitOne();
                    
                    locatorArray.Read(type, locatorCount, reader, hashManager);
                    dispatcher.DispatchCommand(new MarkAssetsAsDirtyAndSave(locatorArray)).WaitOne();
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                    throw;
                }
            }
        }
    }
}