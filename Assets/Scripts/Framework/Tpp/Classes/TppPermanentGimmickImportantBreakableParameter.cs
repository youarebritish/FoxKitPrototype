using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppPermanentGimmickImportantBreakableParameter : DataElement<Data>
    {
        [EntityProperty("life", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Life;

        [EntityProperty("flag1", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Flag1;

        [EntityProperty("flag2", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Flag2;
    }
}
