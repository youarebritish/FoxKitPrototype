using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class CyprusBlockControllerData : Data
    {
        [EntityProperty("enable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Enable;

        [EntityProperty("stageName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String StageName;

        [EntityProperty("commonFilePath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String CommonFilePath;

        [EntityProperty("basePath", FoxDataType.String, FoxContainerType.StaticArray)]
        public String BasePath;

        [EntityProperty("commonBlockSizeInByte", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 CommonBlockSizeInByte;

        [EntityProperty("largeStageBlockSizeInByte", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LargeStageBlockSizeInByte;

        [EntityProperty("smallStageBlockCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 SmallStageBlockCount;

        [EntityProperty("smallStageBlockSizeInByte", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 SmallStageBlockSizeInByte;

        [EntityProperty("largeMissionBlockSizeInByte", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LargeMissionBlockSizeInByte;

        [EntityProperty("smallMissionBlockCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 SmallMissionBlockCount;

        [EntityProperty("smallMissionBlockSizeInByte", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 SmallMissionBlockSizeInByte;

        [EntityProperty("demoBlockCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 DemoBlockCount;

        [EntityProperty("demoBlockSizeInByte", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 DemoBlockSizeInByte;
    }
}
