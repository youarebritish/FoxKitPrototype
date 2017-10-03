using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

namespace FoxKit.FormatHandlers
{
    /// <summary>
    /// Encapsulates various data format importers/exporters, allowing a unified interface for importing or exporting any data type.
    /// </summary>
    public class FormatHandlerProvider
    {
        private readonly IEnumerable<IFoxAssetHandler> handlers;

        public FormatHandlerProvider(IEnumerable<IFoxAssetHandler> formatHandlers)
        {
            handlers = formatHandlers;
        }

        /// <summary>
        /// Determines whether or not a given file extension is supported.
        /// </summary>
        /// <param name="fileExtension">File extension to query. There should be no preceding period (e.g., "fpk" instead of ".fpk").</param>
        /// <returns>True if the extension is supported.</returns>
        public bool IsExtensionSupported(string fileExtension)
        {
            var isSupported = handlers.SelectMany(handler => handler.Extensions).Contains(fileExtension);
            return isSupported;
        }

        /// <summary>
        /// Imports a file.
        /// </summary>
        /// <param name="input">Stream to import the file from.</param>
        /// <param name="path">Path of the file being imported.</param>
        public void Import(Stream input, string path)
        {
            handlers
                .First(handler => handler.Extensions.Contains(Path.GetExtension(path).Replace(".", "")))
                .Import(input, path);
        }
    }
}