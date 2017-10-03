using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class ModelDescription : Data
    {
        [EntityProperty("depends", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> Depends;

        [EntityProperty("partName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String PartName;

        [EntityProperty("buildType", FoxDataType.String, FoxContainerType.StaticArray)]
        public String BuildType;

        [EntityProperty("modelFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String ModelFile;

        [EntityProperty("connectPointFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String ConnectPointFile;

        [EntityProperty("gameRigFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String GameRigFile;

        [EntityProperty("helpBoneFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String HelpBoneFile;

        [EntityProperty("lipAdjustBinaryFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String LipAdjustBinaryFile;

        [EntityProperty("facialSettingFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String FacialSettingFile;

        [EntityProperty("invisibleMeshNames", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> InvisibleMeshNames;

        [EntityProperty("lodFarPixelSize", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LodFarPixelSize;

        [EntityProperty("lodNearPixelSize", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LodNearPixelSize;

        [EntityProperty("lodPolygonSize", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LodPolygonSize;

        [EntityProperty("drawRejectionLevel", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 DrawRejectionLevel;

        [EntityProperty("rejectFarRangeShadowCast", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 RejectFarRangeShadowCast;
    }
}
