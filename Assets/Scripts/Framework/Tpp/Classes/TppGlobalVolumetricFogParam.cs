using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppGlobalVolumetricFogParam : DataElement<Entity>
    {
        [EntityProperty("selfLuminance", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SelfLuminance;

        [EntityProperty("selfColor", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color SelfColor;

        [EntityProperty("skyAlbedo", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color SkyAlbedo;

        [EntityProperty("rayleighScattering", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color RayleighScattering;

        [EntityProperty("mieScattering", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color MieScattering;

        [EntityProperty("mieAnisotropy", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MieAnisotropy;

        [EntityProperty("skyLightGain", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SkyLightGain;

        [EntityProperty("dirLightGain", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DirLightGain;

        [EntityProperty("lightningGain", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LightningGain;

        [EntityProperty("density", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Density;

        [EntityProperty("power", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Power;

        [EntityProperty("near", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Near;

        [EntityProperty("falloff", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Falloff;

        [EntityProperty("exposureOffsetValues", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ExposureOffsetValues;

        [EntityProperty("exposureOffsetTargets", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ExposureOffsetTargets;

        [EntityProperty("flags", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Flags;
    }
}
