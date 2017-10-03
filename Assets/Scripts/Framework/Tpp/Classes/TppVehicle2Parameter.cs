using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppVehicle2Parameter : DataElement<Data>
    {
        [EntityProperty("maxBodyTypeCount", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte MaxBodyTypeCount;
    }
}
