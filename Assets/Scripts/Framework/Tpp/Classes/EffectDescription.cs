using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class EffectDescription : Data
    {
        [EntityProperty("depends", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> Depends;

        [EntityProperty("partName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String PartName;

        [EntityProperty("buildType", FoxDataType.String, FoxContainerType.StaticArray)]
        public String BuildType;

        [EntityProperty("connectDestinationSkelNames", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> ConnectDestinationSkelNames;

        [EntityProperty("connectDestinationCnpNames", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> ConnectDestinationCnpNames;

        [EntityProperty("offsetSkelPositions", FoxDataType.Vector3, FoxContainerType.DynamicArray)]
        public List<Vector3> OffsetSkelPositions;

        [EntityProperty("offsetCnpPositions", FoxDataType.Vector3, FoxContainerType.DynamicArray)]
        public List<Vector3> OffsetCnpPositions;

        [EntityProperty("generalSkelParameters", FoxDataType.Vector4, FoxContainerType.DynamicArray)]
        public List<Vector4> GeneralSkelParameters;

        [EntityProperty("generalCnpParameters", FoxDataType.Vector4, FoxContainerType.DynamicArray)]
        public List<Vector4> GeneralCnpParameters;

        [EntityProperty("effectConnect", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean EffectConnect;

        [EntityProperty("changeEffectConnectSetting", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean ChangeEffectConnectSetting;

        [EntityProperty("visibleModelWithEffect", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean VisibleModelWithEffect;

        [EntityProperty("createStartEffect", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean CreateStartEffect;

        [EntityProperty("effectRandomSeed", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 EffectRandomSeed;

        [EntityProperty("effectKind", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 EffectKind;

        [EntityProperty("effectVariationName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String EffectVariationName;

        [EntityProperty("effectFileFromVfxFileLoader", FoxDataType.String, FoxContainerType.StaticArray)]
        public String EffectFileFromVfxFileLoader;

        [EntityProperty("effectFileFromFilePtr", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String EffectFileFromFilePtr;
    }
}
