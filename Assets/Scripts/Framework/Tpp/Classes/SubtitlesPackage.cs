using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class SubtitlesPackage : Data
    {
        [EntityProperty("subtitlesPackage", FoxDataType.FilePtr, FoxContainerType.DynamicArray)]
        public List<String> subtitlesPackage;

        [EntityProperty("subtitlesStreamData", FoxDataType.FilePtr, FoxContainerType.DynamicArray)]
        public List<String> SubtitlesStreamData;

        [EntityProperty("subtitlesStreamPath", FoxDataType.Path, FoxContainerType.DynamicArray)]
        public List<String> SubtitlesStreamPath;
    }
}
