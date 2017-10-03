using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class DemoStreamAnimation : Data
    {
        [EntityProperty("streamPath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String StreamPath;

        [EntityProperty("demoLength", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 DemoLength;

        [EntityProperty("locatorTypes", FoxDataType.Int32, FoxContainerType.StringMap)]
        public Dictionary<string, Int32> LocatorTypes;

        [EntityProperty("cameraTypes", FoxDataType.Int32, FoxContainerType.StringMap)]
        public Dictionary<string, Int32> CameraTypes;

        [EntityProperty("modelFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> ModelFiles;

        [EntityProperty("helpBoneFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> HelpBoneFiles;

        [EntityProperty("partsFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> PartsFiles;

        [EntityProperty("coverModelFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> CoverModelFiles;

        [EntityProperty("modelPartsDictionary", FoxDataType.String, FoxContainerType.StringMap)]
        public Dictionary<string, String> ModelPartsDictionary;

        [EntityProperty("coverModelDictionary", FoxDataType.String, FoxContainerType.StringMap)]
        public Dictionary<string, String> CoverModelDictionary;

        [EntityProperty("updateJobCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 UpdateJobCount;

        [EntityProperty("modelProxyPaths", FoxDataType.Path, FoxContainerType.StringMap)]
        public Dictionary<string, String> ModelProxyPaths;

        [EntityProperty("partsProxyPaths", FoxDataType.Path, FoxContainerType.StringMap)]
        public Dictionary<string, String> PartsProxyPaths;

        [EntityProperty("dynamicModel", FoxDataType.EntityPtr, FoxContainerType.StringMap)]
        public Dictionary<string, Entity> DynamicModel;

        [EntityProperty("dynamicParts", FoxDataType.EntityPtr, FoxContainerType.StringMap)]
        public Dictionary<string, Entity> DynamicParts;

        [EntityProperty("dynamicFv2", FoxDataType.EntityPtr, FoxContainerType.StringMap)]
        public Dictionary<string, Entity> DynamicFv2;
    }
}
