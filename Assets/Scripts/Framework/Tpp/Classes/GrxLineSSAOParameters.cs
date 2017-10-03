using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class GrxLineSSAOParameters : Entity
    {
        [EntityProperty("innerRadius", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single InnerRadius;

        [EntityProperty("outerRadius", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single OuterRadius;

        [EntityProperty("maxDistanceInner", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaxDistanceInner;

        [EntityProperty("maxDistanceThresholdInner", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaxDistanceThresholdInner;

        [EntityProperty("maxDistanceOuter", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaxDistanceOuter;

        [EntityProperty("maxDistanceThresholdOuter", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaxDistanceThresholdOuter;

        [EntityProperty("contrastLow", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ContrastLow;

        [EntityProperty("contrastHigh", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ContrastHigh;

        [EntityProperty("blurMode", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 BlurMode;

        [EntityProperty("blurRadius", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single BlurRadius;

        [EntityProperty("falloffStart", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single FalloffStart;

        [EntityProperty("falloffRange", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single FalloffRange;

        [EntityProperty("gainonStart", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single GainonStart;

        [EntityProperty("gainonRange", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single GainonRange;
    }
}
