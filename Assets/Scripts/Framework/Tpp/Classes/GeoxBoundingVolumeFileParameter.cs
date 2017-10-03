using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class GeoxBoundingVolumeFileParameter : Data
    {
        [EntityProperty("gridSize", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 GridSize;
    }
}
