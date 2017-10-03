using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class GrPluginSettings : Data
    {
        [EntityProperty("motionBlurConvolutionLevel", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 MotionBlurConvolutionLevel;

        [EntityProperty("exposureCompensation", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ExposureCompensation;

        [EntityProperty("minExposure", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MinExposure;

        [EntityProperty("maxExposure", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaxExposure;

        [EntityProperty("keyValue", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single KeyValue;

        [EntityProperty("bloomSize", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single BloomSize;

        [EntityProperty("bloomBrightnessExtraction", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single BloomBrightnessExtraction;

        [EntityProperty("bloomWeight", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single BloomWeight;

        [EntityProperty("tonemapSpeed", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single TonemapSpeed;

        [EntityProperty("maxLuminanceValue", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaxLuminanceValue;

        [EntityProperty("captureBounceCount", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte CaptureBounceCount;

        [EntityProperty("minDecalArea", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 MinDecalArea;

        [EntityProperty("flags", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Flags;
    }
}
