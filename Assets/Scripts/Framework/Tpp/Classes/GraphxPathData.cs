using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class GraphxPathData : TransformData
    {
        [EntityProperty("nodes", FoxDataType.EntityPtr, FoxContainerType.DynamicArray)]
        public List<Entity> Nodes;

        [EntityProperty("edges", FoxDataType.EntityPtr, FoxContainerType.DynamicArray)]
        public List<Entity> Edges;
    }
}
