using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class ViewGroupControlCondition : Data
    {
        [EntityProperty("flags", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Flags;

        [EntityProperty("condition", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 Condition;

        [EntityProperty("identify", FoxDataType.String, FoxContainerType.StaticArray)]
        public String Identify;
    }
}
