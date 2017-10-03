using System.Collections.Generic;
using System.IO;

namespace FoxKit.FormatHandlers
{
    /// <summary>
    /// A generic interface for classes that can import/export Fox Engine file formats.
    /// </summary>
    public interface IFoxAssetHandler
    {
        /// <summary>
        /// The extension(s) that this handler can import/export.
        /// </summary>
        /// <example>"fpk" (no period)</example>
        List<string> Extensions { get; }

        /// <summary>
        /// Imports a Fox asset from a binary stream.
        /// </summary>
        /// <param name="input">A binary stream of a Fox asset.</param>
        /// <param name="path">Filename of the importing asset.</param>
        void Import(Stream input, string path);

        /// <summary>
        /// Exports a Fox asset to its native format in a binary stream.
        /// </summary>
        /// <param name="asset">An object containing a Fox asset to export.</param>
        /// <param name="path">Path to output the binary file to.</param>
        void Export(object asset, string path);
    }
}