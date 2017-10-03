using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppNvgFilterNoise : Data
    {
        [EntityProperty("visibility", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Visibility;

        [EntityProperty("scale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Scale;

        [EntityProperty("offset", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Offset;

        [EntityProperty("cutScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CutScale;

        [EntityProperty("cutOffset", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CutOffset;

        [EntityProperty("isForceVisible", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IsForceVisible;

        [EntityProperty("color", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color Color;

        [EntityProperty("radialSlope", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RadialSlope;

        [EntityProperty("radialShift", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RadialShift;
    }
}
