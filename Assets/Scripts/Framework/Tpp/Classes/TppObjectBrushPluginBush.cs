using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppObjectBrushPluginBush : Data
    {
        [EntityProperty("parentDataName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String ParentDataName;

        [EntityProperty("visibility", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Visibility;

        [EntityProperty("modelFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String ModelFile;

        [EntityProperty("minSize", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MinSize;

        [EntityProperty("maxSize", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaxSize;

        [EntityProperty("enableLod", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean EnableLod;

        [EntityProperty("modelRejectionLevel", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 ModelRejectionLevel;

        [EntityProperty("reservedCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 ReservedCount;

        [EntityProperty("upgradeLodRateForHighEnd", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single UpgradeLodRateForHighEnd;

        [EntityProperty("gimmickParameter", FoxDataType.EntityPtr, FoxContainerType.StaticArray)]
        public Entity GimmickParameter;

        [EntityProperty("externalGimmickParameter", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink ExternalGimmickParameter;

        [EntityProperty("EdIsSnapNormal", FoxDataType.Bool, FoxContainerType.StaticArray, true)]
        public Boolean EdIsSnapNormal;
    }
}
