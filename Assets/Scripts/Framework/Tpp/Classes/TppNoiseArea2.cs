using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppNoiseArea2 : Data
    {
        [EntityProperty("shapes", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> Shapes;

        [EntityProperty("areaIndex", FoxDataType.Int16, FoxContainerType.StaticArray)]
        public Int16 AreaIndex;

        [EntityProperty("subIndex", FoxDataType.Int16, FoxContainerType.StaticArray)]
        public Int16 SubIndex;
    }
}
