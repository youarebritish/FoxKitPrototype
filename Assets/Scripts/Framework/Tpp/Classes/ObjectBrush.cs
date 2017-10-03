using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class ObjectBrush : TransformData
    {
        [EntityProperty("pluginHandle", FoxDataType.EntityHandle, FoxContainerType.DynamicArray)]
        public List<Entity> PluginHandle;

        [EntityProperty("blockDataName", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> BlockDataName;

        [EntityProperty("filePath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String FilePath;

        [EntityProperty("loadFilePath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String LoadFilePath;

        [EntityProperty("obrFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String ObrFile;

        [EntityProperty("numBlocks", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 NumBlocks;
    }
}
