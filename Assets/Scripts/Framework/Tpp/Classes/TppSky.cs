using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppSky : TransformData
    {
        [EntityProperty("enable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Enable;

        [EntityProperty("priority", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Priority;

        [EntityProperty("model", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String Model;

        [EntityProperty("cloudTexture", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String CloudTexture;

        [EntityProperty("textureRepeats", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 TextureRepeats;

        [EntityProperty("lightExtinction", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LightExtinction;

        [EntityProperty("diffusion", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Diffusion;

        [EntityProperty("dirLightGain", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DirLightGain;

        [EntityProperty("ambLightGain", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single AmbLightGain;

        [EntityProperty("inCloudScatterGain", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single InCloudScatterGain;

        [EntityProperty("density", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Density;

        [EntityProperty("cloudWindInfluence", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CloudWindInfluence;

        [EntityProperty("densityLayerPower", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DensityLayerPower;

        [EntityProperty("densityLayerWindInfluence", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DensityLayerWindInfluence;

        [EntityProperty("dom2TextureRepeats", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Dom2TextureRepeats;

        [EntityProperty("dom2CloudDensity", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Dom2CloudDensity;

        [EntityProperty("dom2WindInfluence", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Dom2WindInfluence;

        [EntityProperty("dom2DensityLayerPower", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Dom2DensityLayerPower;

        [EntityProperty("dom2DensityLayerWindInfluence", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Dom2DensityLayerWindInfluence;

        [EntityProperty("dom3TextureRepeats", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Dom3TextureRepeats;

        [EntityProperty("dom3CloudDensity", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Dom3CloudDensity;

        [EntityProperty("dom3WindInfluence", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Dom3WindInfluence;

        [EntityProperty("dom3DensityLayerPower", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Dom3DensityLayerPower;

        [EntityProperty("dom3DensityLayerWindInfluence", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Dom3DensityLayerWindInfluence;

        [EntityProperty("cylCloudTexture", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String CylCloudTexture;

        [EntityProperty("cylTextureRepeats", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 CylTextureRepeats;

        [EntityProperty("cylCloudDensity", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CylCloudDensity;

        [EntityProperty("cylDiffusion", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CylDiffusion;

        [EntityProperty("cylScatterGain", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CylScatterGain;

        [EntityProperty("cylDirLightGain", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CylDirLightGain;

        [EntityProperty("cylAmbLightGain", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CylAmbLightGain;

        [EntityProperty("cylWindInfluence", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CylWindInfluence;

        [EntityProperty("cylDensityLayerPower", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CylDensityLayerPower;

        [EntityProperty("cylDensityLayerWindInfluence", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CylDensityLayerWindInfluence;
    }
}
