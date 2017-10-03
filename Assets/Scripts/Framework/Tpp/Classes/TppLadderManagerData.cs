using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppLadderManagerData : Data
    {
        [EntityProperty("maxLadderCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 MaxLadderCount;

        [EntityProperty("maxBreakableLadderCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 MaxBreakableLadderCount;
    }
}
