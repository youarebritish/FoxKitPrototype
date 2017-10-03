using System.IO;
using UnityEditor;
using UnityEngine;

namespace FoxKit.Framework.Fox
{
    [DisallowMultipleComponent]
    [ExecuteInEditMode]
    public abstract class Entity : MonoBehaviour
    {
        /// <summary>
        /// Only Entity classes derived from TransformData have a transform.
        /// Since Unity requires all GameObjects to have a transform, we'll fake it by hiding it and fixing its position.
        /// </summary>
        protected readonly bool HasTransform;

        public Entity() : this(false)
        {
        }

        protected Entity(bool hasTransform)
        {            
            HasTransform = hasTransform;
        }

        /// <summary>
        /// Called from the main thread after every Entity in the DataSet has been loaded. Calls to the Unity API are safe here.
        /// </summary>
        public virtual void OnLoaded()
        {
        }
        
        protected virtual void OnEnable()
        {
            if (HasTransform) return;
            
            transform.hideFlags = HideFlags.HideInInspector;
        }

        protected virtual void OnDrawGizmos()
        {
        }

        protected virtual void OnDisable()
        {
        }

        protected virtual void Update()
        {
            if (HasTransform) return;

            transform.position = Vector3.zero;
        }

        /// <summary>
        /// Loads an asset.
        /// </summary>
        /// <param name="assetPath">Relative path of the asset.</param>
        /// <param name="assetExtension">Extension of the asset to load, including the period. This will replace whatever extension is given in assetPath.</param>
        /// <returns>The loaded asset.</returns>
        /// <example>LoadAssetAtPath("/Assets/tpp/environ/object/old_mother_base/heliport/ombs_hlpr001/scenes/ombs_hlpr001_stfr002.fmdl", ".prefab");</example>
        protected static Object LoadAssetAtPath(string assetPath, string assetExtension)
        {
            var assetFullPath = Path.GetDirectoryName(assetPath) + "\\" +
                                Path.GetFileNameWithoutExtension(assetPath) + assetExtension;
            assetFullPath = assetFullPath.Remove(0, 1);
            assetFullPath = assetFullPath.Replace("\\", "/");

            var asset = AssetDatabase.LoadMainAssetAtPath(assetFullPath);
            return asset;
        }
    }
}