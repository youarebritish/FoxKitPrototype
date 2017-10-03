using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class HudBootData : Data
    {
        [EntityProperty("uigFiles", FoxDataType.FilePtr, FoxContainerType.DynamicArray)]
        public List<String> UigFiles;

        [EntityProperty("rawFiles", FoxDataType.FilePtr, FoxContainerType.DynamicArray)]
        public List<String> RawFiles;
    }
}
