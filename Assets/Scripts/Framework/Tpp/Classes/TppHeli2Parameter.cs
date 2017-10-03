using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppHeli2Parameter : DataElement<Data>
    {
        [EntityProperty("partsFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> PartsFiles;

        [EntityProperty("fmdlFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> FmdlFiles;

        [EntityProperty("fcnpFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> FcnpFiles;

        [EntityProperty("gsklFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> GsklFiles;

        [EntityProperty("vfxFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> VfxFiles;

        [EntityProperty("fovaFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> FovaFiles;

        [EntityProperty("mtarFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String MtarFile;
    }
}
