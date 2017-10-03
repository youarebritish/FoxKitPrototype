using System;
using System.Collections;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using FoxTool.Fox.Types.Values;
using UnityEngine;

namespace FoxKit.FormatHandlers.DataSet
{
    public class EntityPropertyConverter
    {
        public object ConvertProperty(FoxProperty property)
        {
            switch (property.ContainerType)
            {
                case FoxContainerType.StaticArray:
                    return ConvertStaticArray(property);
                case FoxContainerType.DynamicArray:
                    break;
                case FoxContainerType.StringMap:
                    break;
                case FoxContainerType.List:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return null;
        }

        private static object ConvertStaticArray(FoxProperty property)
        {
            // As far as I can tell, StaticArrays are not actually collections and only hold a single entry.
            foreach (var entry in property.Container)
            {
                return entry;
            }
            throw new NotSupportedException($"Property '{property.Name}' had no entries. Report the file that caused this.");
        }

        private static object ConvertList(FoxProperty property, Type targetFieldType)
        {
            // TODO Add checks if you were dumb and your property isn't a list
            var list = Activator.CreateInstance(targetFieldType) as IList;

            foreach (var entry in property.Container)
            {
                //list.Add(ConvertValue(entry));
            }
            return null;
        }

        private static object ConvertStringMap(FoxProperty property)
        {
            // Get the generic type to convert to.
            // Create an instance of a list of that type.
            // Add each entry to that list.
            return null;
        }

        private static sbyte ConvertValue(FoxInt8 value)
        {
            return value.Value;
        }

        private static byte ConvertValue(FoxUInt8 value)
        {
            return value.Value;
        }

        private static short ConvertValue(FoxInt16 value)
        {
            return value.Value;
        }

        private static ushort ConvertValue(FoxUInt16 value)
        {
            return value.Value;
        }

        private static int ConvertValue(FoxInt32 value)
        {
            return value.Value;
        }

        private static uint ConvertValue(FoxUInt32 value)
        {
            return value.Value;
        }

        private static long ConvertValue(FoxInt64 value)
        {
            return value.Value;
        }

        private static ulong ConvertValue(FoxUInt64 value)
        {
            return value.Value;
        }

        private static double ConvertValue(FoxDouble value)
        {
            return value.Value;
        }

        private static bool ConvertValue(FoxBool value)
        {
            return value.Value;
        }

        private static string ConvertValue(FoxStringBase value)
        {
            return value.ToString();
        }

        private static string ConvertValue(FoxStringLiteralBase value)
        {
            return value.Literal;
        }

        private static string ConvertValue(FoxPath value)
        {
            // TODO: Resolve file path
            return value.ToString();
        }

        private static Entity ConvertValue(FoxEntityPtr value)
        {
            // TODO
            return null;
        }

        private static Entity ConvertValue(FoxEntityHandle value)
        {
            // TODO
            return null;
        }

        private static object ConvertValue(FoxFilePtr value)
        {
            // TODO
            return null;
        }

        private static Entity ConvertValue(FoxEntityLink value)
        {
            // TODO
            return null;
        }

        private static Vector3 ConvertValue(FoxVector3 value)
        {
            return new Vector3(value.X, value.Y, value.Z);
        }

        private static Vector4 ConvertValue(FoxVector4 value)
        {
            return new Vector4(value.X, value.Y, value.Z, value.W);
        }

        private static Quaternion ConvertValue(FoxQuat value)
        {
            return new Quaternion(value.X, value.Y, value.Z, value.W);
        }

        private static object ConvertValue(FoxMatrix3 value)
        {
            // TODO
            return null;
        }

        private static Matrix4x4 ConvertValue(FoxMatrix4 value)
        {
            var unityMatrix = new Matrix4x4();

            var row1 = new Vector4(value.Row1Value1, value.Row1Value2, value.Row1Value3, value.Row1Value4);
            var row2 = new Vector4(value.Row2Value1, value.Row2Value2, value.Row2Value3, value.Row2Value4);
            var row3 = new Vector4(value.Row3Value1, value.Row3Value2, value.Row3Value3, value.Row3Value4);
            var row4 = new Vector4(value.Row4Value1, value.Row4Value2, value.Row4Value3, value.Row4Value4);

            unityMatrix.SetRow(0, row1);
            unityMatrix.SetRow(1, row2);
            unityMatrix.SetRow(2, row3);
            unityMatrix.SetRow(3, row4);

            return unityMatrix;
        }

        private static Color ConvertValue(FoxColor value)
        {
            var unityColor = new Color(value.Red, value.Green, value.Blue, value.Alpha);
            return unityColor;
        }

        private static object ConvertValue(FoxWideVector3 value)
        {
            throw new NotImplementedException("FoxWideVector3 not yet implemented. Please report what file caused this error.");
        }

        private static object ConvertValue(FoxPropertyInfo value)
        {
            throw new NotImplementedException("FoxPropertyInfo not yet implemented. Please report what file caused this error.");
        }
    }
}