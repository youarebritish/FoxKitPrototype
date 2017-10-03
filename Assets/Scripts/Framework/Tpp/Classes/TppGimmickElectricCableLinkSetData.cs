using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppGimmickElectricCableLinkSetData : Data
    {
        [EntityProperty("electricCableData", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink ElectricCableData;

        [EntityProperty("poleData", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink PoleData;

        [EntityProperty("electricCable", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> ElectricCable;

        [EntityProperty("pole", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> Pole;

        [EntityProperty("cnpIndex", FoxDataType.UInt8, FoxContainerType.DynamicArray)]
        public List<Byte> CnpIndex;
    }
}
