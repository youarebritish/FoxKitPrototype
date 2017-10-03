using FoxKit.Framework.Fox;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;
using FoxTool.Fox.Types.Values;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    /// <summary>
    /// A set of instances of a StaticMesh.
    /// </summary>
    public class StaticModelArray : Data
    {
        /// <summary>
        /// The .fmdl file to load and render for each of the instances.
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

        /// <summary>
        /// Parent Locator, if any.
        /// </summary>
        [EntityProperty("parentLocator", FoxDataType.EntityLink)]
        public FoxEntityLink ParentLocator;

        /// <summary>
        /// Transforms of the instances of the static model.
        /// </summary>
        [EntityProperty("transforms", FoxDataType.Matrix4, FoxContainerType.DynamicArray)]
        public List<Matrix4x4> Transforms;

        /// <summary>
        /// Presumably a uint representation of colors to tint the StaticModel instances.
        /// </summary>
        [EntityProperty("colors", FoxDataType.UInt32, FoxContainerType.DynamicArray)]
        public List<uint> Colors;

        public override void OnLoaded()
        {
            base.OnLoaded();

            // Load the model.
            var model = LoadAssetAtPath(ModelFile, ".prefab");
            if (model == null)
            {
                Debug.LogError("Could not find model " + ModelFile);
                return;
            }
            // Convert the transform matrices to Transforms.
            foreach (var matrix in Transforms)
            {
                var instance = Instantiate(model) as UnityEngine.GameObject;

                // TODO: When EntityLinks are handled, parent this to ParentLocator.
                instance.transform.SetParent(transform);
                DecomposeTransformMatrix(matrix, instance.transform);
            }
        }

        static void DecomposeTransformMatrix(Matrix4x4 matrix, Transform transform)
        {
            // Extract translation.
            transform.localPosition = new Vector3(matrix.m32, matrix.m31, matrix.m30);
            
            // Extract rotation.
            Vector3 forward;
            forward.x = matrix.m02;
            forward.y = matrix.m12;
            forward.z = matrix.m22;

            Vector3 upwards;
            upwards.x = matrix.m01;
            upwards.y = matrix.m11;
            upwards.z = matrix.m21;

            transform.localRotation = Quaternion.LookRotation(forward, upwards);
            transform.localRotation = new Quaternion(transform.localRotation.z, transform.localRotation.y, transform.localRotation.x, transform.localRotation.w);

            // Extract scale.
            var scale = new Vector3
            (
                matrix.GetRow(0).magnitude,
                matrix.GetRow(1).magnitude,
                matrix.GetRow(2).magnitude
            );
            if (Vector3.Cross(matrix.GetRow(0), matrix.GetRow(1)).normalized != (Vector3)matrix.GetRow(2).normalized)
            {
                scale.x *= -1;
            }

            transform.localScale = scale;
        }
    }
}