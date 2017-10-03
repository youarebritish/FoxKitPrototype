using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppPlayer2AdditionalMtarData : Data
    {
        [EntityProperty("mtarFiles", FoxDataType.FilePtr, FoxContainerType.DynamicArray)]
        public List<String> MtarFiles;
    }
}
