using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TerrainMaterialConfigration : Data
    {
        [EntityProperty("slot0", FoxDataType.UInt32, FoxContainerType.DynamicArray)]
        public List<UInt32> Slot0;

        [EntityProperty("slot1", FoxDataType.UInt32, FoxContainerType.DynamicArray)]
        public List<UInt32> Slot1;

        [EntityProperty("slot2", FoxDataType.UInt32, FoxContainerType.DynamicArray)]
        public List<UInt32> Slot2;

        [EntityProperty("slot3", FoxDataType.UInt32, FoxContainerType.DynamicArray)]
        public List<UInt32> Slot3;
    }
}
