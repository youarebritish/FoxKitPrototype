using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppSpotLight : TransformData
    {
        [EntityProperty("color", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color Color;

        [EntityProperty("reachPoint", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 ReachPoint;

        [EntityProperty("BynaryData", FoxDataType.UInt32, FoxContainerType.DynamicArray)]
        public List<UInt32> BynaryData;

        [EntityProperty("lightArea", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink LightArea;

        [EntityProperty("irradiationPoint", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink IrradiationPoint;

        [EntityProperty("lookAtPoint", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink LookAtPoint;

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

        [EntityProperty("umbraAngle", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single UmbraAngle;

        [EntityProperty("penumbraAngle", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single PenumbraAngle;

        [EntityProperty("attenuationExponent", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single AttenuationExponent;

        [EntityProperty("shadowUmbraAngle", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ShadowUmbraAngle;

        [EntityProperty("shadowPenumbraAngle", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ShadowPenumbraAngle;

        [EntityProperty("shadowAttenuationExponent", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ShadowAttenuationExponent;

        [EntityProperty("dimmer", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Dimmer;

        [EntityProperty("shadowBias", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ShadowBias;

        [EntityProperty("viewBias", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ViewBias;

        [EntityProperty("powerScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single PowerScale;

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
