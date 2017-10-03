using System.IO;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Values;
using UnityEditor;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    /// <summary>
    /// An instance of a static mesh.
    /// </summary>
    [TppClass(ClassCategory.Model)]
    public class StaticModel : TransformData
    {
        /// <summary>
        /// The .fmdl file to load and render.
        /// </summary>
        [EntityProperty("modelFile", FoxDataType.FilePtr)]
        public string ModelFile;

        /// <summary>
        /// .geom file (what is this?)
        /// </summary>
        [EntityProperty("geomFile", FoxDataType.FilePtr)]
        public string GeomFile;

        /// <summary>
        /// Seemingly always false. Is this whether or not to render the "geom" file?
        /// </summary>
        [EntityProperty("isVisibleGeom", FoxDataType.Bool)]
        public bool IsVisibleGeom;

        /// <summary>
        /// Unknown.
        /// </summary>
        [EntityProperty("isIsolated", FoxDataType.Bool)]
        public bool IsIsolated = true;

        /// <summary>
        /// Unknown.
        /// </summary>
        [EntityProperty("lodFarSize", FoxDataType.Float)]
        public float LodFarSize = -1;

        /// <summary>
        /// Unknown.
        /// </summary>
        [EntityProperty("lodNearSize", FoxDataType.Float)]
        public float LodNearSize = -1;

        /// <summary>
        /// Unknown.
        /// </summary>
        [EntityProperty("lodPolygonSize", FoxDataType.Float)]
        public float LodPolygonSize = -1;

        /// <summary>
        /// Presumably a tint applied to the material.
        /// </summary>
        [EntityProperty("color", FoxDataType.Color)]
        public Color Color = Color.white;

        /// <summary>
        /// Unknown.
        /// </summary>
        [EntityProperty("drawRejectionLevel", FoxDataType.Int32)]
        public int DrawRejectionLevel = 8;

        /// <summary>
        /// Unknown.
        /// </summary>
        [EntityProperty("drawMode", FoxDataType.Int32)]
        public int DrawMode;

        /// <summary>
        /// Unknown.
        /// </summary>
        [EntityProperty("rejectFarRangeShadowCast", FoxDataType.Int32)]
        public int RejectFarRangeShadowCast = 2;
        
        public override void OnLoaded()
        {
            base.OnLoaded();
            
            // Load and instantiate the model.
            var model = LoadAssetAtPath(ModelFile, ".prefab");
            if (model != null)
            {
                var modelInstance = PrefabUtility.InstantiatePrefab(model) as UnityEngine.GameObject;
                modelInstance?.transform.SetParent(transform, false);
            }
            else
            {
                Debug.LogError("Could not find model " + ModelFile);
            }
        }
    }
}