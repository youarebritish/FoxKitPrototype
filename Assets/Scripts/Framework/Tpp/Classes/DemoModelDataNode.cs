using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class DemoModelDataNode : Data
    {
        [EntityProperty("partNames", FoxDataType.String, FoxContainerType.StringMap)]
        public Dictionary<string, String> PartNames;

        [EntityProperty("target", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink Target;
    }
}
