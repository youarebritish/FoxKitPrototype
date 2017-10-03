using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppPermanentGimmickDoorParameter : DataElement<Data>
    {
        [EntityProperty("attribute", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Attribute;
    }
}
