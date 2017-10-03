using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppObjectBrushPluginSkeletonModel : Data
    {
        [EntityProperty("parentDataName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String ParentDataName;

        [EntityProperty("visibility", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Visibility;

        [EntityProperty("modelFile", FoxDataType.FilePtr, FoxContainerType.DynamicArray)]
        public List<String> ModelFile;

        [EntityProperty("geomFile", FoxDataType.FilePtr, FoxContainerType.DynamicArray)]
        public List<String> GeomFile;

        [EntityProperty("animFile", FoxDataType.Path, FoxContainerType.DynamicArray)]
        public List<String> AnimFile;

        [EntityProperty("animWindyFile", FoxDataType.Path, FoxContainerType.DynamicArray)]
        public List<String> AnimWindyFile;

        [EntityProperty("mtarFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String MtarFile;

        [EntityProperty("soundSeType", FoxDataType.String, FoxContainerType.StaticArray)]
        public String SoundSeType;

        [EntityProperty("minSize", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MinSize;

        [EntityProperty("maxSize", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaxSize;

        [EntityProperty("isGeomActivity", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IsGeomActivity;

        [EntityProperty("thinkOutRate", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ThinkOutRate;

        [EntityProperty("extensionRadius", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ExtensionRadius;

        [EntityProperty("reserveResourcePlugin", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 ReserveResourcePlugin;

        [EntityProperty("reserveResourcePerBlock", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 ReserveResourcePerBlock;

        [EntityProperty("lodLength", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LodLength;

        [EntityProperty("lodLengthForHighEnd", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LodLengthForHighEnd;
    }
}
