using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class GeoTrap : TransformData
    {
        [EntityProperty("conditionArray", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> ConditionArray;

        [EntityProperty("enable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Enable;
    }
}
