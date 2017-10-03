using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppSharedGimmickData : Data
    {
        [EntityProperty("modelFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String ModelFile;

        [EntityProperty("geomFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String GeomFile;

        [EntityProperty("breakedModelFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String BreakedModelFile;

        [EntityProperty("breakedGeomFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String BreakedGeomFile;

        [EntityProperty("partsFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String PartsFile;

        [EntityProperty("numDynamicGimmick", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 NumDynamicGimmick;

        [EntityProperty("locaterFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String LocaterFile;

        [EntityProperty("flags1", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Flags1;

        [EntityProperty("flags2", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Flags2;
    }
}
