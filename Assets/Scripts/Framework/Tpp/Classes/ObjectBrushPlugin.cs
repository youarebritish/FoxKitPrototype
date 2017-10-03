using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class ObjectBrushPlugin : Data
    {
        [EntityProperty("parentDataName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String ParentDataName;

        [EntityProperty("visibility", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Visibility;
    }
}
