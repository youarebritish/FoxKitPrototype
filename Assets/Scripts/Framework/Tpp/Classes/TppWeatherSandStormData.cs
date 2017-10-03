using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppWeatherSandStormData : Data
    {
        [EntityProperty("vfxFileSandStormStart", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String VfxFileSandStormStart;

        [EntityProperty("vfxFileSandStormFar", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String VfxFileSandStormFar;

        [EntityProperty("vfxFileSandStormNear", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String VfxFileSandStormNear;

        [EntityProperty("vfxFileSandStormCamera", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String VfxFileSandStormCamera;

        [EntityProperty("sandStormFarDistance", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SandStormFarDistance;

        [EntityProperty("sandStormFarHeight", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SandStormFarHeight;

        [EntityProperty("sandStormNearDistance", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SandStormNearDistance;

        [EntityProperty("sandStormNearHeight", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SandStormNearHeight;

        [EntityProperty("noiseScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single NoiseScale;

        [EntityProperty("noiseOffset", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single NoiseOffset;

        [EntityProperty("noiseCutScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single NoiseCutScale;

        [EntityProperty("noiseCutOffset", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single NoiseCutOffset;

        [EntityProperty("noiseColor", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color NoiseColor;

        [EntityProperty("noiseSunLightColorMul", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean NoiseSunLightColorMul;
    }
}
