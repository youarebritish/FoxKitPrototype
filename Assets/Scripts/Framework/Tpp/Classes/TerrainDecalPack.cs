using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TerrainDecalPack : Data
    {
        [EntityProperty("terrainDecalPackFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String TerrainDecalPackFile;

        [EntityProperty("materialLinks", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> MaterialLinks;
    }
}
