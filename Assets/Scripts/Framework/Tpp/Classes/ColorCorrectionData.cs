using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class ColorCorrectionData : Data
    {
        [EntityProperty("textureLUT", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String TextureLUT;

        [EntityProperty("startSlope", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single StartSlope;

        [EntityProperty("endSlope", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single EndSlope;

        [EntityProperty("showBaseLUT", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean ShowBaseLUT;

        [EntityProperty("showFilterLUT", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean ShowFilterLUT;

        [EntityProperty("colorScale", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color ColorScale;
    }
}
