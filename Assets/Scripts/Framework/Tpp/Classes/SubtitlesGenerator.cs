using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class SubtitlesGenerator : Data
    {
        [EntityProperty("files", FoxDataType.FilePtr, FoxContainerType.DynamicArray)]
        public List<String> Files;

        [EntityProperty("rawFiles", FoxDataType.FilePtr, FoxContainerType.DynamicArray)]
        public List<String> RawFiles;

        [EntityProperty("key", FoxDataType.String, FoxContainerType.StaticArray)]
        public String Key;

        [EntityProperty("color", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color Color;

        [EntityProperty("offset", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 Offset;

        [EntityProperty("size", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 Size;

        [EntityProperty("fontSpace", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single FontSpace;

        [EntityProperty("lineSpace", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LineSpace;

        [EntityProperty("hAlign", FoxDataType.Int8, FoxContainerType.StaticArray)]
        public SByte HAlign;

        [EntityProperty("vAlign", FoxDataType.Int8, FoxContainerType.StaticArray)]
        public SByte VAlign;

        [EntityProperty("bAlign", FoxDataType.Int8, FoxContainerType.StaticArray)]
        public SByte BAlign;

        [EntityProperty("fontName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String FontName;

        [EntityProperty("autoLineFeed", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean AutoLineFeed;
    }
}
