using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppLadderEntryPointData : Data
    {
        [EntityProperty("entryType", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 EntryType;

        [EntityProperty("locateStep", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LocateStep;
    }
}
