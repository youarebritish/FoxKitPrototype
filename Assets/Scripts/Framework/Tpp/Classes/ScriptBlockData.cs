using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class ScriptBlockData : Data
    {
        [EntityProperty("enabled", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Enabled;

        [EntityProperty("sizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 SizeInBytes;

        [EntityProperty("prerequisites", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> Prerequisites;
    }
}
