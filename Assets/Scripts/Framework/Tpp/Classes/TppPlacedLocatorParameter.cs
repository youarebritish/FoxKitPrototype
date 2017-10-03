using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppPlacedLocatorParameter : DataElement<Data>
    {
        [EntityProperty("equipIdStrCode32", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 EquipIdStrCode32;
    }
}
