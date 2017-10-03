using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace FoxKit.FormatHandlers.Script
{
    /// <summary>
    /// Imports Lua scripts.
    /// </summary>
    public class LuaScriptHandler : IFoxAssetHandler
    {
        private static readonly List<string> DecompilableExtensions = new List<string>
        {
            "lua",
        };
        private readonly string assetPath;

        public List<string> Extensions => DecompilableExtensions;

        public LuaScriptHandler(string assetPath)
        {
            this.assetPath = assetPath;
        }

        public void Export(object asset, string path)
        {
            throw new NotImplementedException();
        }

        public void Import(Stream input, string path)
        {
            using (var reader = new StreamReader(input))
            {
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(Directory.GetParent(assetPath) + "/" + path));
                    using (var writer = new StreamWriter(Directory.GetParent(assetPath) + "/" + path))
                    {
                        var contents = reader.ReadToEnd();
                        writer.Write(contents);
                    }
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