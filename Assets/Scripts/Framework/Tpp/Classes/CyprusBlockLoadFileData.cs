using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class CyprusBlockLoadFileData : Data
    {
        [EntityProperty("path", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String Path;

        [EntityProperty("block", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Block;

        [EntityProperty("load", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Load;
    }
}
