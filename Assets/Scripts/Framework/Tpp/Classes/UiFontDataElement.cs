using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class UiFontDataElement : DataElement<Data>
    {
        [EntityProperty("language", FoxDataType.String, FoxContainerType.StaticArray)]
        public String Language;

        [EntityProperty("fontName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String FontName;

        [EntityProperty("fontFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String FontFile;

        [EntityProperty("texturePath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String TexturePath;

        [EntityProperty("fontWidth", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single FontWidth;

        [EntityProperty("fontHeight", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single FontHeight;

        [EntityProperty("textSpace", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single TextSpace;

        [EntityProperty("lineSpace", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LineSpace;

        [EntityProperty("fontEdge", FoxDataType.Vector4, FoxContainerType.StaticArray)]
        public Vector4 FontEdge;
    }
}
