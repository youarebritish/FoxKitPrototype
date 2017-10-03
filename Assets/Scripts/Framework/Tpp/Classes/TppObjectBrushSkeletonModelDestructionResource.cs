using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppObjectBrushSkeletonModelDestructionResource : Data
    {
        [EntityProperty("rootCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 RootCount;

        [EntityProperty("trunkCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 TrunkCount;

        [EntityProperty("pluginName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String PluginName;

        [EntityProperty("flags", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Flags;

        [EntityProperty("rootModelFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String RootModelFile;

        [EntityProperty("rootGeomFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String RootGeomFile;

        [EntityProperty("trunkPartsFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String TrunkPartsFile;
    }
}
