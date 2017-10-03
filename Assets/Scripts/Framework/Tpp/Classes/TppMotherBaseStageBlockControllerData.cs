using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppMotherBaseStageBlockControllerData : Data
    {
        [EntityProperty("createMode", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 CreateMode;

        [EntityProperty("motherBaseId", FoxDataType.UInt16, FoxContainerType.StaticArray)]
        public UInt16 MotherBaseId;

        [EntityProperty("stageName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String StageName;

        [EntityProperty("layoutBlockSizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LayoutBlockSizeInBytes;

        [EntityProperty("commonBlockSizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 CommonBlockSizeInBytes;

        [EntityProperty("uniqueBlockCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 UniqueBlockCount;

        [EntityProperty("uniqueBlockSizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 UniqueBlockSizeInBytes;

        [EntityProperty("divisionBlockCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 DivisionBlockCount;

        [EntityProperty("divisionBlockSizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 DivisionBlockSizeInBytes;

        [EntityProperty("cluster00divisionPackageIds", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Cluster00divisionPackageIds;

        [EntityProperty("cluster01divisionPackageIds", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Cluster01divisionPackageIds;

        [EntityProperty("cluster02divisionPackageIds", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Cluster02divisionPackageIds;

        [EntityProperty("cluster03divisionPackageIds", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Cluster03divisionPackageIds;

        [EntityProperty("cluster04divisionPackageIds", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Cluster04divisionPackageIds;

        [EntityProperty("cluster05divisionPackageIds", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Cluster05divisionPackageIds;

        [EntityProperty("cluster06divisionPackageIds", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Cluster06divisionPackageIds;

        [EntityProperty("cluster07divisionPackageIds", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Cluster07divisionPackageIds;

        [EntityProperty("clusterPositions", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 ClusterPositions;

        [EntityProperty("clusterRequestRadiuses", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 ClusterRequestRadiuses;

        [EntityProperty("clusterRequireRadiuses", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 ClusterRequireRadiuses;
    }
}
