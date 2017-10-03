using GzsTool.Core.Common;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using GzsTool.Core.Common.Interfaces;

namespace FoxKit.FormatHandlers.Archive
{
    /// <summary>
    /// Handles fpk, fpkd, pftxs and sbp archives. Based on https://github.com/Atvaark/GzsTool/blob/master/GzsTool/Program.cs.
    /// </summary>
    public class ArchiveHandler<T> where T : ArchiveFile, new()
    {
        private static readonly List<string> DecompilableExtensions = new List<string>
        {
            "fpk",
            "fpkd",
            "pftxs",
            "sbp"
        };

        public List<string> Extensions => DecompilableExtensions;

        public void Export(T asset, string path)
        {
            var directory = Path.GetDirectoryName(path);
            WriteArchive(asset, directory);
        }

        public T Import(Stream input, string path)
        {
            T file = new T();
            file.Read(input);
            foreach (var foundFile in file.ExportFiles(input))
            {
                Debug.Log(foundFile.FileName);
            }

            return file;
        }

        private static void WriteArchive(ArchiveFile archiveFile, string workingDirectory)
        {
            string outputPath = Path.Combine(workingDirectory, archiveFile.Name);
            string fileSystemInputDirectory = string.Format("{0}\\{1}_{2}", workingDirectory,
                Path.GetFileNameWithoutExtension(archiveFile.Name),
                Path.GetExtension(archiveFile.Name).Replace(".", ""));
            IDirectory inputDirectory = new FileSystemDirectory(fileSystemInputDirectory);
            using (FileStream output = new FileStream(outputPath, FileMode.Create))
            {
                archiveFile.Write(output, inputDirectory);
            }
        }
    }
}