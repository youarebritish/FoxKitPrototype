using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class UiPaletteData : Data
    {
        [EntityProperty("colors", FoxDataType.Color, FoxContainerType.StringMap)]
        public Dictionary<string, Color> Colors;
    }
}
