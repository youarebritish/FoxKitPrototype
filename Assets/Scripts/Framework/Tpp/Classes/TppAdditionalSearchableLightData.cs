using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppAdditionalSearchableLightData : Data
    {
        [EntityProperty("count", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Count;
    }
}
