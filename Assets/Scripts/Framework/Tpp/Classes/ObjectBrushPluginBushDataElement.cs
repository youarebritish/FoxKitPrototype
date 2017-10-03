using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class ObjectBrushPluginBushDataElement : DataElement<Data>
    {
        [EntityProperty("lodMeshName", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> LodMeshName;

        [EntityProperty("lodDistance", FoxDataType.Float, FoxContainerType.DynamicArray)]
        public List<Single> LodDistance;

        [EntityProperty("lodDistanceHighEnd", FoxDataType.Float, FoxContainerType.DynamicArray)]
        public List<Single> LodDistanceHighEnd;

        [EntityProperty("rotationRate", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RotationRate;

        [EntityProperty("elasticRate", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ElasticRate;

        [EntityProperty("alphaMinimizeDist", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single AlphaMinimizeDist;

        [EntityProperty("alphaMaximizeDist", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single AlphaMaximizeDist;

        [EntityProperty("baseDensity", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single BaseDensity;

        [EntityProperty("camoufDensity", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CamoufDensity;

        [EntityProperty("camofRadius", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CamofRadius;

        [EntityProperty("camofHeight", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CamofHeight;

        [EntityProperty("modelRadius", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ModelRadius;

        [EntityProperty("stopEyeRadius", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single StopEyeRadius;

        [EntityProperty("stopEyeHeight", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single StopEyeHeight;

        [EntityProperty("noiseSeType", FoxDataType.String, FoxContainerType.StaticArray)]
        public String NoiseSeType;

        [EntityProperty("bushFlags", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 BushFlags;

        [EntityProperty("baseCycleSpeedRate", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single BaseCycleSpeedRate;

        [EntityProperty("windAmplitude", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single WindAmplitude;

        [EntityProperty("windDirYAxisFixZero", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean WindDirYAxisFixZero;

        [EntityProperty("windOffsetFactor", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single WindOffsetFactor;

        [EntityProperty("bulletEffect", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String BulletEffect;

        [EntityProperty("fairEffect", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String FairEffect;

        [EntityProperty("rainEffect", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String RainEffect;
    }
}
