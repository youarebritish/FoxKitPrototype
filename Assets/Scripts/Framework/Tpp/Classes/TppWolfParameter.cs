using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppWolfParameter : DataElement<Data>
    {
        [EntityProperty("partsFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String PartsFile;

        [EntityProperty("mtarFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String MtarFile;

        [EntityProperty("mogFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String MogFile;

        [EntityProperty("fovaFiles", FoxDataType.FilePtr, FoxContainerType.DynamicArray)]
        public List<String> FovaFiles;
    }
}
