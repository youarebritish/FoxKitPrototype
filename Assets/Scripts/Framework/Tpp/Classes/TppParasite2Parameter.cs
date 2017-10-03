using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppParasite2Parameter : DataElement<Data>
    {
        [EntityProperty("partsFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String PartsFile;

        [EntityProperty("motionGraphFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String MotionGraphFile;

        [EntityProperty("mtarFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String MtarFile;

        [EntityProperty("partsFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> PartsFiles;

        [EntityProperty("vfxFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> VfxFiles;

        [EntityProperty("fmdlFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> FmdlFiles;

        [EntityProperty("geomFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> GeomFiles;

        [EntityProperty("fovaFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> FovaFiles;
    }
}
