using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TerrainRender : TransformData
    {
        [EntityProperty("filePath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String FilePath;

        [EntityProperty("loadFilePath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String LoadFilePath;

        [EntityProperty("dummyFilePath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String DummyFilePath;

        [EntityProperty("filePtr", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String FilePtr;

        [EntityProperty("meterPerOneRepeat", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MeterPerOneRepeat;

        [EntityProperty("meterPerPixel", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MeterPerPixel;

        [EntityProperty("isWireFrame", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IsWireFrame;

        [EntityProperty("lodFlag", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean LodFlag;

        [EntityProperty("isDebugMaterial", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IsDebugMaterial;

        [EntityProperty("materials", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink Materials;

        [EntityProperty("lodParam", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LodParam;

        [EntityProperty("materialConfigs", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> MaterialConfigs;

        [EntityProperty("packedAlbedoTexturePath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String PackedAlbedoTexturePath;

        [EntityProperty("packedNormalTexturePath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String PackedNormalTexturePath;

        [EntityProperty("packedSrmTexturePath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String PackedSrmTexturePath;

        [EntityProperty("packedMaterialIdentify", FoxDataType.UInt64, FoxContainerType.StaticArray)]
        public UInt64 PackedMaterialIdentify;

        [EntityProperty("isFourceUsePackedMaterialTexture", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IsFourceUsePackedMaterialTexture;

        [EntityProperty("baseColorTexture", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String BaseColorTexture;

        [EntityProperty("materialLodScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaterialLodScale;

        [EntityProperty("materialLodNearOffset", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaterialLodNearOffset;

        [EntityProperty("materialLodFarOffset", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaterialLodFarOffset;

        [EntityProperty("materialLodHeightOffset", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaterialLodHeightOffset;

        [EntityProperty("worldTextureMode", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 WorldTextureMode;

        [EntityProperty("worldTextureDividedNumX", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 WorldTextureDividedNumX;

        [EntityProperty("worldTextureDividedNumZ", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 WorldTextureDividedNumZ;

        [EntityProperty("worldTextureTilePathes", FoxDataType.Path, FoxContainerType.DynamicArray)]
        public List<String> WorldTextureTilePathes;
    }
}
