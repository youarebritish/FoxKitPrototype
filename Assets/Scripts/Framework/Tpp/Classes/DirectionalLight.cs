using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class DirectionalLight : TransformData
    {
        [EntityProperty("color", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color Color;

        [EntityProperty("direction", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 Direction;

        [EntityProperty("shadowRange", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ShadowRange;

        [EntityProperty("shadowRangeExtra", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ShadowRangeExtra;

        [EntityProperty("hiResShadowRange", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single HiResShadowRange;

        [EntityProperty("shadowProjectionRange", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ShadowProjectionRange;

        [EntityProperty("shadowFadeRange", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ShadowFadeRange;

        [EntityProperty("selfShadowBias", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SelfShadowBias;

        [EntityProperty("temperature", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Temperature;

        [EntityProperty("colorDeflection", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ColorDeflection;

        [EntityProperty("lux", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Lux;

        [EntityProperty("lightSize", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LightSize;

        [EntityProperty("shadowMaskSpecular", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ShadowMaskSpecular;

        [EntityProperty("shadowOffsetStartAngle", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ShadowOffsetStartAngle;

        [EntityProperty("shadowOffsetEndAngle", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ShadowOffsetEndAngle;

        [EntityProperty("diatanceFade_StartDistance", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DiatanceFade_StartDistance;

        [EntityProperty("distanceFade_FadeoutRange", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DistanceFade_FadeoutRange;

        [EntityProperty("lightFlags", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LightFlags;
    }
}
