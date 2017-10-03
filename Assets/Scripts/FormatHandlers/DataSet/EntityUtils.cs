using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.FormatHandlers.DataSet
{
    /// <summary>
    /// Provides utility functions for Entity-related tasks.
    /// </summary>
    public static class EntityUtils
    {
        /// <summary>
        /// Maps Fox data types to their native Unity counterparts.
        /// </summary>
        private static Dictionary<FoxDataType, Type> TypeMappingTable { get; } = new Dictionary<FoxDataType, Type>
        {
            {FoxDataType.UInt8, typeof(byte)},
            {FoxDataType.Int8, typeof(sbyte)},
            {FoxDataType.Int16, typeof(short)},
            {FoxDataType.UInt16, typeof(ushort)},
            {FoxDataType.Int32, typeof(int)},
            {FoxDataType.UInt32, typeof(uint)},
            {FoxDataType.Int64, typeof(long)},
            {FoxDataType.UInt64, typeof(ulong)},
            {FoxDataType.Float, typeof(float)},
            {FoxDataType.Double, typeof(double)},
            {FoxDataType.Bool, typeof(bool)},
            {FoxDataType.String, typeof(string)},
            {FoxDataType.Path, typeof(string)},                 // TODO
            {FoxDataType.EntityPtr, typeof(Entity)},
            {FoxDataType.Vector3, typeof(Vector3)},
            {FoxDataType.Vector4, typeof(Vector4)},
            {FoxDataType.Quat, typeof(Quaternion)},
            {FoxDataType.Matrix3, typeof(Matrix4x4)},           // TODO
            {FoxDataType.Matrix4, typeof(Matrix4x4)},
            {FoxDataType.Color, typeof(Color)},
            {FoxDataType.FilePtr, typeof(string)},              // TODO
            {FoxDataType.EntityHandle, typeof(Entity)},
            {FoxDataType.EntityLink, typeof(FoxEntityLink)},    // TODO
            {FoxDataType.PropertyInfo, null},                   // TODO
            {FoxDataType.WideVector3, null}                     // TODO
        };

        /// <summary>
        /// Gets the native type for a given Fox data type.
        /// </summary>
        /// <param name="foxType">The Fox data type to get the native property for.</param>
        /// <returns>The corresponding native type.</returns>
        public static Type GetNativeTypeForFoxType(FoxDataType foxType)
        {
            return TypeMappingTable[foxType];
        }
    }
}