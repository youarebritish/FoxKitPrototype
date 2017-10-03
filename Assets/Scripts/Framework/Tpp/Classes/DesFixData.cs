using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class DesFixData : Data
    {
        [EntityProperty("elementNames", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> ElementNames;
    }
}
