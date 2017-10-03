using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppWalkerGear2Parameter : DataElement<Data>
    {
        [EntityProperty("partsFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String PartsFile;

        [EntityProperty("motionGraphFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String MotionGraphFile;

        [EntityProperty("mtarFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String MtarFile;

        [EntityProperty("extensionMtarFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String ExtensionMtarFile;

        [EntityProperty("vfxFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> VfxFiles;

        [EntityProperty("extraPartsFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> ExtraPartsFiles;
    }
}
