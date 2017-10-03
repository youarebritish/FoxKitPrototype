using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class LuxuryBlockControllerData : Data
    {
        [EntityProperty("blockWidthX", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 BlockWidthX;

        [EntityProperty("blockWidthZ", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 BlockWidthZ;

        [EntityProperty("centerIndexX", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 CenterIndexX;

        [EntityProperty("centerIndexZ", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 CenterIndexZ;

        [EntityProperty("blockLoadMargin", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 BlockLoadMargin;

        [EntityProperty("maxBlockIndexMapCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 MaxBlockIndexMapCount;

        [EntityProperty("maxPathListCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 MaxPathListCount;
    }
}
