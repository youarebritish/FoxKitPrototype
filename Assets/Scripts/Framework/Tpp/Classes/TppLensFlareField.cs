using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppLensFlareField : Data
    {
        [EntityProperty("shapeType", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 ShapeType;

        [EntityProperty("interpType", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 InterpType;

        [EntityProperty("debugDrawFlag", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean DebugDrawFlag;

        [EntityProperty("debugDrawColor", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color DebugDrawColor;

        [EntityProperty("innerScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single InnerScale;

        [EntityProperty("centerScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CenterScale;

        [EntityProperty("outerScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single OuterScale;

        [EntityProperty("innerValue", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single InnerValue;

        [EntityProperty("centerValue", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CenterValue;

        [EntityProperty("outerValue", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single OuterValue;

        [EntityProperty("reverse", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Reverse;
    }
}
