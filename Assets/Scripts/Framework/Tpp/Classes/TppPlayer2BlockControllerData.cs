using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppPlayer2BlockControllerData : Data
    {
        [EntityProperty("configuration_commonMotionBlockSize", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Configuration_commonMotionBlockSize;

        [EntityProperty("configuration_commonMotionBlockSizePs3", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Configuration_commonMotionBlockSizePs3;

        [EntityProperty("configuration_additiveMotionBlockCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Configuration_additiveMotionBlockCount;

        [EntityProperty("configuration_additiveMotionBlockSize", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Configuration_additiveMotionBlockSize;

        [EntityProperty("configuration_partsBlockCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Configuration_partsBlockCount;

        [EntityProperty("configuration_partsBlockSize", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Configuration_partsBlockSize;

        [EntityProperty("instanceSettings_instancePackagePath", FoxDataType.String, FoxContainerType.StaticArray)]
        public String InstanceSettings_instancePackagePath;

        [EntityProperty("instanceSettings_instanceBlockSize", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 InstanceSettings_instanceBlockSize;

        [EntityProperty("instanceSettings_commonMotionTypeName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String InstanceSettings_commonMotionTypeName;

        [EntityProperty("instanceSettings_partsTypeNames", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> InstanceSettings_partsTypeNames;

        [EntityProperty("instanceSettings_partsTypeInitial", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> InstanceSettings_partsTypeInitial;
    }
}
