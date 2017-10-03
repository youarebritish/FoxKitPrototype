using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppGimmickBrokenCandleBank : Data
    {
        [EntityProperty("referencePartsPathList", FoxDataType.Path, FoxContainerType.DynamicArray)]
        public List<String> ReferencePartsPathList;

        [EntityProperty("modelFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String ModelFile;

        [EntityProperty("connectPointFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String ConnectPointFile;

        [EntityProperty("soundFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String SoundFile;

        [EntityProperty("instanceCount", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte InstanceCount;
    }
}
