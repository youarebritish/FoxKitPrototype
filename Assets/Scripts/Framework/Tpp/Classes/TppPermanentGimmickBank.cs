using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppPermanentGimmickBank : Data
    {
        [EntityProperty("partsFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String PartsFile;

        [EntityProperty("flags", FoxDataType.UInt16, FoxContainerType.StaticArray)]
        public UInt16 Flags;

        [EntityProperty("instanceCount", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte InstanceCount;
    }
}
