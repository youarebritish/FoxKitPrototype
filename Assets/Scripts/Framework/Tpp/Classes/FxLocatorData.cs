using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class FxLocatorData : TransformData
    {
        [EntityProperty("variationName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String VariationName;

        [EntityProperty("effectInstanceName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String EffectInstanceName;

        [EntityProperty("enableUserRandomSeed", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean EnableUserRandomSeed;

        [EntityProperty("userRandomSeed", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 UserRandomSeed;

        [EntityProperty("shapeKeep", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean ShapeKeep;

        [EntityProperty("createOnInitialize", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean CreateOnInitialize;

        [EntityProperty("blockMemoryAllocation", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean BlockMemoryAllocation;

        [EntityProperty("vfxFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String VfxFile;
    }
}
