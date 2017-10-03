using FoxKit.FormatHandlers.LocatorArray;
using UnityEditor;
using UnityEngine;

namespace FoxKit.Framework.Concurrency
{
    /// <summary>
    /// Kind of a hack. Refactor this. Marks an asset as dirty and saves it.
    /// </summary>
    public class MarkAssetsAsDirtyAndSave : IUnityThreadCommand
    {
        private readonly Object asset;

        public MarkAssetsAsDirtyAndSave(Object asset)
        {
            this.asset = asset;
        }

        public void Execute()
        {
            EditorUtility.SetDirty(asset);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }
    }
}
