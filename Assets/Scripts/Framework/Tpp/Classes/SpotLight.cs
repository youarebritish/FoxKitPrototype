﻿using FoxKit.Framework.Fox;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;
using System.Collections.Generic;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    /// <summary>
    /// A spot light. Note that currently lights will look different in Unity as MGSV has inverse square falloff for point lights versus quadratic in Unity.
    /// In addition, I don't yet know how to convert lumens to Unity light intensity.
    /// </summary>
    [TppClass(ClassCategory.Light)]
    public class SpotLight : TransformData
    {
        /// <summary>
        /// Color of the light.
        /// </summary>
        [EntityProperty("color", FoxDataType.Color)]
        public Color Color = Color.white;

        [EntityProperty("reachPoint", FoxDataType.Vector3)]
        public Vector3 ReachPoint;

        /// <remarks>
        /// Note the unusual spelling and capitalization. Do not "fix" them.
        /// </remarks>
        [EntityProperty("BynaryData", FoxDataType.UInt32, FoxContainerType.DynamicArray)]
        public List<uint> BinaryData;

        [EntityProperty("lightArea", FoxDataType.EntityLink)]
        public FoxEntityLink LightArea;

        [EntityProperty("irradiationPoint", FoxDataType.EntityLink)]
        public FoxEntityLink IrradiationPoint;

        [EntityProperty("lookAtPoint", FoxDataType.EntityLink)]
        public FoxEntityLink LookAtPoint;

        [EntityProperty("outerRange", FoxDataType.Float)]
        public float OuterRange;

        [EntityProperty("innerRange", FoxDataType.Float)]
        public float InnerRange;

        /// <summary>
        /// Temperature of the light, presumably in Kelvins.
        /// </summary>
        [EntityProperty("temperature", FoxDataType.Float)]
        public float Temperature;

        [EntityProperty("colorDeflection", FoxDataType.Float)]
        public float ColorDeflection;

        /// <summary>
        /// Brightness of the light in lumens.
        /// </summary>
        [EntityProperty("lumen", FoxDataType.Float)]
        public float Lumen;

        [EntityProperty("lightSize", FoxDataType.Float)]
        public float LightSize;

        [EntityProperty("umbraAngle", FoxDataType.Float)]
        public float UmbraAngle;

        [EntityProperty("penumbraAngle", FoxDataType.Float)]
        public float PenumbraAngle;

        [EntityProperty("attenuationExponent", FoxDataType.Float)]
        public float AttenuationExponent;

        [EntityProperty("shadowUmbraAngle", FoxDataType.Float)]
        public float ShadowUmbraAngle;

        [EntityProperty("shadowPenumbraAngle", FoxDataType.Float)]
        public float ShadowPenumbraAngle;

        [EntityProperty("shadowAttenuationExponent", FoxDataType.Float)]
        public float ShadowAttenuationExponent;

        [EntityProperty("dimmer", FoxDataType.Float)]
        public float Dimmer;

        [EntityProperty("shadowBias", FoxDataType.Float)]
        public float ShadowBias = -15;

        [EntityProperty("viewBias", FoxDataType.Float)]
        public float ViewBias = -15;

        [EntityProperty("powerScale", FoxDataType.Float)]
        public float PowerScale = 1;

        [EntityProperty("LodFarSize", FoxDataType.Float)]
        public float LodFarSize = 5;

        [EntityProperty("LodNearSize", FoxDataType.Float)]
        public float LodNearSize = 40;

        [EntityProperty("LodShadowDrawRate", FoxDataType.Float)]
        public float LodShadowDrawRate = 1;

        [EntityProperty("lightFlags", FoxDataType.UInt32)]
        public uint lightFlags;

        [EntityProperty("lodRadiusLevel", FoxDataType.Int32)]
        public int LodRadiusLevel;

        [EntityProperty("lodFadeType", FoxDataType.UInt8)]
        public byte LodFadeType;

        /// <summary>
        /// Unity light instance.
        /// </summary>
        private Light unityLight;

        public override void OnLoaded()
        {
            base.OnLoaded();

            unityLight = gameObject.AddComponent<Light>();
            unityLight.type = LightType.Spot;
            unityLight.color = Color;
            unityLight.colorTemperature = Temperature;
            unityLight.intensity = Lumen / 10000;
            unityLight.range = OuterRange;
            unityLight.shadows = LightShadows.Hard;
            unityLight.shadowBias = ShadowBias;
            unityLight.spotAngle = PenumbraAngle;
        }
    }
}