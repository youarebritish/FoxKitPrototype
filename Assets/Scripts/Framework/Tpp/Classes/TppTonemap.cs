using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppTonemap : Data
    {
        [EntityProperty("enable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Enable;

        [EntityProperty("threshold", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Threshold;

        [EntityProperty("range", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Range;
    }
}
