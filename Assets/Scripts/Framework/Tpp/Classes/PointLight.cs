using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class PointLight : TransformData
    {
        [EntityProperty("color", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color Color;

        [EntityProperty("reachPoint", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 ReachPoint;

        [EntityProperty("lightArea", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink LightArea;

        [EntityProperty("irradiationPoint", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink IrradiationPoint;

        [EntityProperty("outerRange", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single OuterRange;

        [EntityProperty("innerRange", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single InnerRange;

        [EntityProperty("temperature", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Temperature;

        [EntityProperty("colorDeflection", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ColorDeflection;

        [EntityProperty("lumen", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Lumen;

        [EntityProperty("lightSize", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LightSize;

        [EntityProperty("dimmer", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Dimmer;

        [EntityProperty("shadowBias", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ShadowBias;

        [EntityProperty("LodFarSize", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LodFarSize;

        [EntityProperty("LodNearSize", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LodNearSize;

        [EntityProperty("LodShadowDrawRate", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LodShadowDrawRate;

        [EntityProperty("lightFlags", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LightFlags;

        [EntityProperty("lodRadiusLevel", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 LodRadiusLevel;

        [EntityProperty("lodFadeType", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte LodFadeType;
    }
}
