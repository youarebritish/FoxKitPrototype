using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppLightProbe : TransformData
    {
        [EntityProperty("enable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Enable;

        [EntityProperty("lightArea", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink LightArea;

        [EntityProperty("innerArea", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink InnerArea;

        [EntityProperty("shCoefficientsData", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink ShCoefficientsData;

        [EntityProperty("onLights", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> OnLights;

        [EntityProperty("offLights", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> OffLights;

        [EntityProperty("innerScaleXPositive", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single InnerScaleXPositive;

        [EntityProperty("innerScaleXNegative", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single InnerScaleXNegative;

        [EntityProperty("innerScaleYPositive", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single InnerScaleYPositive;

        [EntityProperty("innerScaleYNegative", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single InnerScaleYNegative;

        [EntityProperty("innerScaleZPositive", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single InnerScaleZPositive;

        [EntityProperty("innerScaleZNegative", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single InnerScaleZNegative;

        [EntityProperty("priority", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 Priority;

        [EntityProperty("debugMode", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 DebugMode;

        [EntityProperty("drawRejectionLevel", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 DrawRejectionLevel;

        [EntityProperty("shapeType", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 ShapeType;

        [EntityProperty("exposure", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Exposure;

        [EntityProperty("localFlags", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LocalFlags;

        [EntityProperty("occlusionModeOpenRate", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single OcclusionModeOpenRate;
    }
}
