using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppCollectionLocatorArray : Data
    {
        [EntityProperty("positions", FoxDataType.Vector3, FoxContainerType.DynamicArray)]
        public List<Vector3> Positions;

        [EntityProperty("rotations", FoxDataType.UInt32, FoxContainerType.DynamicArray)]
        public List<UInt32> Rotations;

        [EntityProperty("infos", FoxDataType.UInt32, FoxContainerType.DynamicArray)]
        public List<UInt32> Infos;

        [EntityProperty("segmentIndices", FoxDataType.UInt16, FoxContainerType.DynamicArray)]
        public List<UInt16> SegmentIndices;

        [EntityProperty("locatorIndices", FoxDataType.UInt16, FoxContainerType.DynamicArray)]
        public List<UInt16> LocatorIndices;

        [EntityProperty("locatorCounts", FoxDataType.UInt16, FoxContainerType.DynamicArray)]
        public List<UInt16> LocatorCounts;

        [EntityProperty("groupIds", FoxDataType.UInt8, FoxContainerType.DynamicArray)]
        public List<Byte> GroupIds;

        [EntityProperty("segmentInfoIndices", FoxDataType.UInt16, FoxContainerType.DynamicArray)]
        public List<UInt16> SegmentInfoIndices;

        [EntityProperty("segmentInfoCounts", FoxDataType.UInt16, FoxContainerType.DynamicArray)]
        public List<UInt16> SegmentInfoCounts;
    }
}
