using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class FacialSettingData : Data
    {
        [EntityProperty("aspectMaskList", FoxDataType.EntityPtr, FoxContainerType.DynamicArray)]
        public List<Entity> AspectMaskList;

        [EntityProperty("mouthMask", FoxDataType.EntityPtr, FoxContainerType.StaticArray)]
        public Entity MouthMask;

        [EntityProperty("lipMask", FoxDataType.EntityPtr, FoxContainerType.StaticArray)]
        public Entity LipMask;

        [EntityProperty("rootName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String RootName;
    }
}
