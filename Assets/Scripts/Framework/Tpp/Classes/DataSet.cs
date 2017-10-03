using FoxKit.Framework.Fox;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types;
using System.Collections.Generic;
using System.IO;
using UnityEditor;

namespace FoxKit.Framework.Tpp.Classes
{
    /// <summary>
    /// A DataSet possesses a set of entities.
    /// </summary>
    public class DataSet : Data
    {
        [EntityProperty("dataList", FoxDataType.EntityPtr, FoxContainerType.StringMap)]
        public Dictionary<string, Entity> DataList;
        
        /// <summary>
        /// Get an entity entry by key.
        /// </summary>
        /// <param name="key">Key of the entity to get.</param>
        /// <returns>The entity with the given key.</returns>
        public Entity GetData(string key)
        {
            return DataList[key];
        }

        /// <summary>
        /// Get the entity list.
        /// </summary>
        /// <returns>The entity list.</returns>
        public Dictionary<string, Entity> GetDataList()
        {
            return DataList;
        }

        private string foxFilePath;

        /// <summary>
        /// Sets the name of the DataSet (the name of its fox2 file).
        /// </summary>
        /// <param name="foxFileName">Name of the fox2 file representing this DataSet.</param>
        public void SetPath(string foxFilePath)
        {
            this.foxFilePath = foxFilePath;
        }

        public override void OnLoaded()
        {
            base.OnLoaded();
            name = Path.GetFileNameWithoutExtension(foxFilePath);
        }

        public void SaveToPrefab()
        {
            var prefabPath = Path.GetDirectoryName(foxFilePath) + "/" + Path.GetFileNameWithoutExtension(foxFilePath) + ".prefab";
            Directory.CreateDirectory(Path.GetDirectoryName(prefabPath));
            PrefabUtility.CreatePrefab(prefabPath, gameObject, ReplacePrefabOptions.ConnectToPrefab);
        }
    }
}