using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppPickableLocatorParameter : DataElement<Data>
    {
        [EntityProperty("equipIdStrCode32", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 EquipIdStrCode32;

        [EntityProperty("countRaw", FoxDataType.UInt16, FoxContainerType.StaticArray)]
        public UInt16 CountRaw;

        [EntityProperty("countSubRaw", FoxDataType.UInt16, FoxContainerType.StaticArray)]
        public UInt16 CountSubRaw;

        [EntityProperty("flag", FoxDataType.UInt16, FoxContainerType.StaticArray)]
        public UInt16 Flag;

        [EntityProperty("reserved", FoxDataType.UInt16, FoxContainerType.StaticArray)]
        public UInt16 Reserved;
    }
}
