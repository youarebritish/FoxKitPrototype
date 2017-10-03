using System;
using System.Globalization;
using System.IO;
using System.Linq;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types;

namespace FoxTool
{
    internal static class ExtensionMethods
    {
        internal static void Skip(this BinaryReader reader, int count)
        {
            reader.BaseStream.Seek(count, SeekOrigin.Current);
        }

        internal static void WriteZeros(this BinaryWriter writer, int count)
        {
            byte[] zeros = new byte[count];
            writer.Write(zeros);
        }

        internal static void AlignRead(this Stream input, int alignment)
        {
            long alignmentRequired = input.Position % alignment;
            if (alignmentRequired > 0)
                input.Position += alignment - alignmentRequired;
        }

        internal static void AlignWrite(this Stream output, int alignment, byte data)
        {
            long alignmentRequired = output.Position % alignment;
            if (alignmentRequired > 0)
            {
                byte[] alignmentBytes = Enumerable.Repeat(data, (int)(alignment - alignmentRequired)).ToArray();
                output.Write(alignmentBytes, 0, alignmentBytes.Length);
            }
        }

        internal static string ReadString(this BinaryReader binaryReader, int count)
        {
            return new string(binaryReader.ReadChars(count));
        }

        internal static bool IsPrintable(this string s)
        {
            return s.Any(c => char.IsControl(c) || char.IsHighSurrogate(c) || char.IsLowSurrogate(c)) == false;
        }

        internal static FoxContainerType ParseFoxContainerType(string foxContainerType)
        {
            switch (foxContainerType)
            {
                case "StaticArray":
                    return FoxContainerType.StaticArray;
                case "DynamicArray":
                    return FoxContainerType.DynamicArray;
                case "StringMap":
                    return FoxContainerType.StringMap;
                case "List":
                    return FoxContainerType.List;
                default:
                    throw new ArgumentOutOfRangeException("foxContainerType");
            }
        }

        internal static FoxDataType ParseFoxDataType(string foxDataType)
        {
            switch (foxDataType)
            {
                case "int8":
                    return FoxDataType.Int8;
                case "uint8":
                    return FoxDataType.UInt8;
                case "int16":
                    return FoxDataType.Int16;
                case "uint16":
                    return FoxDataType.UInt16;
                case "int32":
                    return FoxDataType.Int32;
                case "uint32":
                    return FoxDataType.UInt32;
                case "int64":
                    return FoxDataType.Int64;
                case "uint64":
                    return FoxDataType.UInt64;
                case "float":
                    return FoxDataType.Float;
                case "double":
                    return FoxDataType.Double;
                case "bool":
                    return FoxDataType.Bool;
                case "String":
                    return FoxDataType.String;
                case "Path":
                    return FoxDataType.Path;
                case "EntityPtr":
                    return FoxDataType.EntityPtr;
                case "Vector3":
                    return FoxDataType.Vector3;
                case "Vector4":
                    return FoxDataType.Vector4;
                case "Quat":
                    return FoxDataType.Quat;
                case "Matrix3":
                    return FoxDataType.Matrix3;
                case "Matrix4":
                    return FoxDataType.Matrix4;
                case "Color":
                    return FoxDataType.Color;
                case "FilePtr":
                    return FoxDataType.FilePtr;
                case "EntityHandle":
                    return FoxDataType.EntityHandle;
                case "EntityLink":
                    return FoxDataType.EntityLink;
                case "PropertyInfo":
                    return FoxDataType.PropertyInfo;
                case "WideVector3":
                    return FoxDataType.WideVector3;
                default:
                    throw new ArgumentOutOfRangeException("foxDataType");
            }
        }

        internal static string ToXmlName(this FoxDataType type)
        {
            switch (type)
            {
                case FoxDataType.Int8:
                    return "int8";
                case FoxDataType.UInt8:
                    return "uint8";
                case FoxDataType.Int16:
                    return "int16";
                case FoxDataType.UInt16:
                    return "uint16";
                case FoxDataType.Int32:
                    return "int32";
                case FoxDataType.UInt32:
                    return "uint32";
                case FoxDataType.Int64:
                    return "int64";
                case FoxDataType.UInt64:
                    return "uint64";
                case FoxDataType.Float:
                    return "float";
                case FoxDataType.Double:
                    return "double";
                case FoxDataType.Bool:
                    return "bool";
                case FoxDataType.String:
                    return "String";
                case FoxDataType.Path:
                    return "Path";
                case FoxDataType.EntityPtr:
                    return "EntityPtr";
                case FoxDataType.Vector3:
                    return "Vector3";
                case FoxDataType.Vector4:
                    return "Vector4";
                case FoxDataType.Quat:
                    return "Quat";
                case FoxDataType.Matrix3:
                    return "Matrix3";
                case FoxDataType.Matrix4:
                    return "Matrix4";
                case FoxDataType.Color:
                    return "Color";
                case FoxDataType.FilePtr:
                    return "FilePtr";
                case FoxDataType.EntityHandle:
                    return "EntityHandle";
                case FoxDataType.EntityLink:
                    return "EntityLink";
                case FoxDataType.PropertyInfo:
                    return "PropertyInfo";
                case FoxDataType.WideVector3:
                    return "WideVector3";
                default:
                    throw new ArgumentOutOfRangeException("type");
            }
        }

        internal static string ToStringRoundtrip(this float value)
        {
            if (value.Equals(0.0f) && BitConverter.GetBytes(value)[BitConverter.IsLittleEndian ? 3 : 0] == 0x80)
            {
                return "-0";
            }
            return value.ToString("r", CultureInfo.InvariantCulture);
        }

        internal static float ParseFloatRoundtrip(string text)
        {
            if (text == "-0")
            {
                return -0f;
            }
            return float.Parse(text, CultureInfo.InvariantCulture);
        }
    }
}
