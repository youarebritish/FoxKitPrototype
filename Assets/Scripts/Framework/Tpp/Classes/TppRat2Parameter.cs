using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppRat2Parameter : DataElement<Data>
    {
        [EntityProperty("partsFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String PartsFile;

        [EntityProperty("mtarFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String MtarFile;

        [EntityProperty("fovaFiles", FoxDataType.FilePtr, FoxContainerType.DynamicArray)]
        public List<String> FovaFiles;
    }
}
