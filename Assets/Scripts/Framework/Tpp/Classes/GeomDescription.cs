using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class GeomDescription : Data
    {
        [EntityProperty("depends", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> Depends;

        [EntityProperty("partName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String PartName;

        [EntityProperty("buildType", FoxDataType.String, FoxContainerType.StaticArray)]
        public String BuildType;

        [EntityProperty("geomFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String GeomFile;

        [EntityProperty("skeletonName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String SkeletonName;

        [EntityProperty("offsetScale", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 OffsetScale;

        [EntityProperty("offsetRotQuat", FoxDataType.Quat, FoxContainerType.StaticArray)]
        public Quaternion OffsetRotQuat;

        [EntityProperty("offsetTranslation", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 OffsetTranslation;
    }
}
