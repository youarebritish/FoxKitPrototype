using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class PhPrimitiveShapeParam : Entity
    {
        [EntityProperty("offset", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 Offset;

        [EntityProperty("rotation", FoxDataType.Quat, FoxContainerType.StaticArray)]
        public Quaternion Rotation;

        [EntityProperty("size", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 Size;

        [EntityProperty("type", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 Type;
    }
}
