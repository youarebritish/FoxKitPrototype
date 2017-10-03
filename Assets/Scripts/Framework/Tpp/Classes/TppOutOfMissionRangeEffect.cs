using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppOutOfMissionRangeEffect : Data
    {
        [EntityProperty("enable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Enable;

        [EntityProperty("lutTexture", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String LutTexture;

        [EntityProperty("startSlope", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single StartSlope;

        [EntityProperty("endSlope", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single EndSlope;

        [EntityProperty("blendRatio", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single BlendRatio;

        [EntityProperty("colorScale", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color ColorScale;

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

        [EntityProperty("cinemaScopeSlope", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CinemaScopeSlope;

        [EntityProperty("cinemaScopeShift", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CinemaScopeShift;
    }
}
