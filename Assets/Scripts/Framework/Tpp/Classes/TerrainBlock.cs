using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TerrainBlock : Data
    {
        [EntityProperty("id", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Id;

        [EntityProperty("terrainName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String TerrainName;

        [EntityProperty("filePtr", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String FilePtr;

        [EntityProperty("filePath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String FilePath;

        [EntityProperty("pos", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 Pos;

        public override void OnLoaded()
        {
            base.OnLoaded();
            transform.position = Pos;
        }
    }
}
