using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class ObjectBrushBlock : Data
    {
        [EntityProperty("filePath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String FilePath;

        [EntityProperty("obrbFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String ObrbFile;

        [EntityProperty("blockId", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 BlockId;

        [EntityProperty("objectBrushName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String ObjectBrushName;
    }
}
