using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppPermanentGimmickSearchLightParameter : DataElement<Data>
    {
        [EntityProperty("rotationLimitLeftRight", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RotationLimitLeftRight;

        [EntityProperty("rotationLimitUp", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RotationLimitUp;

        [EntityProperty("rotationLimitDown", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RotationLimitDown;

        [EntityProperty("rangeDiscovery", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RangeDiscovery;

        [EntityProperty("rangeLeftRightDiscovery", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RangeLeftRightDiscovery;

        [EntityProperty("rangeUpDownDiscovery", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RangeUpDownDiscovery;

        [EntityProperty("rangeDim", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RangeDim;

        [EntityProperty("rangeLeftRightDim", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RangeLeftRightDim;

        [EntityProperty("rangeUpDownDim", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RangeUpDownDim;
    }
}
