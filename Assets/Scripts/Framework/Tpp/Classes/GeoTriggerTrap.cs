using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class GeoTriggerTrap : TransformData
    {
        [EntityProperty("stateFlag", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 StateFlag;

        [EntityProperty("uniqueId", FoxDataType.String, FoxContainerType.StaticArray)]
        public String UniqueId;

        [EntityProperty("groupTags", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> GroupTags;
    }
}
