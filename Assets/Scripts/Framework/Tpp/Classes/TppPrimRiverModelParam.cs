using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppPrimRiverModelParam : Data
    {
        [EntityProperty("primRiverGroupName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String PrimRiverGroupName;

        [EntityProperty("visibility", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Visibility;

        [EntityProperty("baseTextureName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String BaseTextureName;

        [EntityProperty("normalTextureName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String NormalTextureName;

        [EntityProperty("cubeMapName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String CubeMapName;

        [EntityProperty("lightCaptureLocator", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink LightCaptureLocator;

        [EntityProperty("scrollDirection0", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ScrollDirection0;

        [EntityProperty("scrollSpeed0", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ScrollSpeed0;

        [EntityProperty("scrollScale0", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ScrollScale0;

        [EntityProperty("scrollDirection1", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ScrollDirection1;

        [EntityProperty("scrollSpeed1", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ScrollSpeed1;

        [EntityProperty("scrollScale1", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ScrollScale1;

        [EntityProperty("transparency", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Transparency;

        [EntityProperty("transparencyDepthBlend", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single TransparencyDepthBlend;

        [EntityProperty("reflectionRate", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ReflectionRate;

        [EntityProperty("distortionPower", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DistortionPower;

        [EntityProperty("surfaceShadowRate", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SurfaceShadowRate;

        [EntityProperty("oilIntensity", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single OilIntensity;

        [EntityProperty("useHnmTexture", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean UseHnmTexture;

        [EntityProperty("debugReset", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean DebugReset;
    }
}
