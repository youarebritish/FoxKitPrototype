using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppSpeechData : Data
    {
        [EntityProperty("enabled", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Enabled;

        [EntityProperty("files", FoxDataType.FilePtr, FoxContainerType.DynamicArray)]
        public List<String> Files;
    }
}
