using System;
using System.IO;
using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;
using FoxTool.Fox.Types.Values;

namespace FoxTool.Fox.Containers
{
    internal static class FoxContainerFactory
    {
        public static IFoxContainer ReadFoxContainer(Stream input, FoxDataType dataType, FoxContainerType containerType,
            short valueCount)
        {
            var container = CreateTypedContainer(dataType, containerType);
            container.Read(input, valueCount);
            return container;
        }

        public static IFoxContainer CreateTypedContainer(FoxDataType dataType, FoxContainerType containerType)
        {
            IFoxContainer container;
            switch (dataType)
            {
                case FoxDataType.Int8:
                    container = CreateContainer<FoxInt8>(containerType);
                    break;
                case FoxDataType.UInt8:
                    container = CreateContainer<FoxUInt8>(containerType);
                    break;
                case FoxDataType.Int16:
                    container = CreateContainer<FoxInt16>(containerType);
                    break;
                case FoxDataType.UInt16:
                    container = CreateContainer<FoxUInt16>(containerType);
                    break;
                case FoxDataType.Int32:
                    container = CreateContainer<FoxInt32>(containerType);
                    break;
                case FoxDataType.UInt32:
                    container = CreateContainer<FoxUInt32>(containerType);
                    break;
                case FoxDataType.Int64:
                    container = CreateContainer<FoxInt64>(containerType);
                    break;
                case FoxDataType.UInt64:
                    container = CreateContainer<FoxUInt64>(containerType);
                    break;
                case FoxDataType.Float:
                    container = CreateContainer<FoxFloat>(containerType);
                    break;
                case FoxDataType.Double:
                    container = CreateContainer<FoxDouble>(containerType);
                    break;
                case FoxDataType.Bool:
                    container = CreateContainer<FoxBool>(containerType);
                    break;
                case FoxDataType.String:
                    container = CreateContainer<FoxString>(containerType);
                    break;
                case FoxDataType.Path:
                    container = CreateContainer<FoxPath>(containerType);
                    break;
                case FoxDataType.EntityPtr:
                    container = CreateContainer<FoxEntityPtr>(containerType);
                    break;
                case FoxDataType.Vector3:
                    container = CreateContainer<FoxVector3>(containerType);
                    break;
                case FoxDataType.Vector4:
                    container = CreateContainer<FoxVector4>(containerType);
                    break;
                case FoxDataType.Quat:
                    container = CreateContainer<FoxQuat>(containerType);
                    break;
                case FoxDataType.Matrix3:
                    container = CreateContainer<FoxMatrix3>(containerType);
                    break;
                case FoxDataType.Matrix4:
                    container = CreateContainer<FoxMatrix4>(containerType);
                    break;
                case FoxDataType.Color:
                    container = CreateContainer<FoxColor>(containerType);
                    break;
                case FoxDataType.FilePtr:
                    container = CreateContainer<FoxFilePtr>(containerType);
                    break;
                case FoxDataType.EntityHandle:
                    container = CreateContainer<FoxEntityHandle>(containerType);
                    break;
                case FoxDataType.EntityLink:
                    container = CreateContainer<FoxEntityLink>(containerType);
                    break;
                case FoxDataType.PropertyInfo:
                    container = CreateContainer<FoxPropertyInfo>(containerType);
                    break;
                case FoxDataType.WideVector3:
                    container = CreateContainer<FoxWideVector3>(containerType);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("dataType");
            }
            return container;
        }

        private static IFoxContainer CreateContainer<T>(FoxContainerType containerType) where T : IFoxType, new()
        {
            switch (containerType)
            {
                case FoxContainerType.StaticArray:
                    return new FoxStaticArray<T>();
                case FoxContainerType.DynamicArray:
                    return new FoxDynamicArray<T>();
                case FoxContainerType.StringMap:
                    return new FoxStringMap<T>();
                case FoxContainerType.List:
                    return new FoxList<T>();
                default:
                    throw new ArgumentOutOfRangeException("containerType");
            }
        }
    }
}
