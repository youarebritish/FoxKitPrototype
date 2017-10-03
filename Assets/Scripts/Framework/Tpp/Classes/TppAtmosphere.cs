using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppAtmosphere : Data
    {
        [EntityProperty("atshFilePath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String AtshFilePath;

        [EntityProperty("pcspFilePath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String PcspFilePath;

        [EntityProperty("atshFilePtr", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String AtshFilePtr;

        [EntityProperty("pcspFilePtr", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String PcspFilePtr;

        [EntityProperty("capturePosition", FoxDataType.EntityHandle, FoxContainerType.StaticArray)]
        public Entity CapturePosition;

        [EntityProperty("rayleighHeightScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RayleighHeightScale;

        [EntityProperty("rayleighScatteringCoefficient", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 RayleighScatteringCoefficient;

        [EntityProperty("rayleighScatteringCoefficientOfCloudySky", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 RayleighScatteringCoefficientOfCloudySky;

        [EntityProperty("mieHeightScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MieHeightScale;

        [EntityProperty("mieAbsorptionRate", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MieAbsorptionRate;

        [EntityProperty("mieAnisotropy", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MieAnisotropy;

        [EntityProperty("mieScatteringCoefficient", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 MieScatteringCoefficient;

        [EntityProperty("mieAnisotropyOfCloudySky", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MieAnisotropyOfCloudySky;

        [EntityProperty("mieScatteringCoefficientOfCloudySky", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 MieScatteringCoefficientOfCloudySky;

        [EntityProperty("multiScatteringOrder", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 MultiScatteringOrder;

        [EntityProperty("groundColor", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color GroundColor;

        [EntityProperty("northAngle", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single NorthAngle;

        [EntityProperty("latitude", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Latitude;

        [EntityProperty("longitude", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Longitude;

        [EntityProperty("gmtTimeDifference", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 GmtTimeDifference;

        [EntityProperty("year", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Year;

        [EntityProperty("month", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Month;

        [EntityProperty("day", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Day;

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

        [EntityProperty("shadowMaskSpecular", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ShadowMaskSpecular;

        [EntityProperty("dirLightFadeStart", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DirLightFadeStart;

        [EntityProperty("dirLightFadeLength", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DirLightFadeLength;

        [EntityProperty("sunLux", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SunLux;

        [EntityProperty("moonLux", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MoonLux;

        [EntityProperty("starLight", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single StarLight;

        [EntityProperty("sunMoonSize", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SunMoonSize;

        [EntityProperty("sunMoonIntensity", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SunMoonIntensity;

        [EntityProperty("sunTexture", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String SunTexture;

        [EntityProperty("moonTexture", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String MoonTexture;

        [EntityProperty("moonColor", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color MoonColor;

        [EntityProperty("sunColorExtinctionOfClearSky", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color SunColorExtinctionOfClearSky;

        [EntityProperty("sunColorOfCloudySky", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color SunColorOfCloudySky;

        [EntityProperty("skyLightSunScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SkyLightSunScale;

        [EntityProperty("skyColorSunScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SkyColorSunScale;

        [EntityProperty("daySkyAmbientScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DaySkyAmbientScale;

        [EntityProperty("dirLightSunLimitAngle", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DirLightSunLimitAngle;

        [EntityProperty("dirLightMoonLimitAngle", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DirLightMoonLimitAngle;

        [EntityProperty("dirLightAttenuStart", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DirLightAttenuStart;

        [EntityProperty("dirLightAttenuEnd", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DirLightAttenuEnd;

        [EntityProperty("fixedLightDirSunRise", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 FixedLightDirSunRise;

        [EntityProperty("fixedLightDirSunSet", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 FixedLightDirSunSet;

        [EntityProperty("fixedLightDirMoonRise", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 FixedLightDirMoonRise;

        [EntityProperty("fixedLightDirMoonSet", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 FixedLightDirMoonSet;

        [EntityProperty("fixedRisingSunDir", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 FixedRisingSunDir;

        [EntityProperty("fixedFallingSunDir", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 FixedFallingSunDir;

        [EntityProperty("fixedRisingMoonDir", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 FixedRisingMoonDir;

        [EntityProperty("fixedFallingMoonDir", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 FixedFallingMoonDir;

        [EntityProperty("skyLightLuminanceScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SkyLightLuminanceScale;

        [EntityProperty("numBands", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 NumBands;

        [EntityProperty("coefficients", FoxDataType.Vector4, FoxContainerType.DynamicArray)]
        public List<Vector4> Coefficients;

        [EntityProperty("cloudiness", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Cloudiness;

        [EntityProperty("influenceOfFog", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single InfluenceOfFog;

        [EntityProperty("localFlags", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LocalFlags;

        [EntityProperty("priority", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Priority;

        [EntityProperty("interpolateTimeInSecondOfDirLightSteppedMove", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single InterpolateTimeInSecondOfDirLightSteppedMove;

        [EntityProperty("divisonNumOfDirLightSteppedMove", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 DivisonNumOfDirLightSteppedMove;
    }
}
