using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    public abstract class PathBase : TransformData
    {
        [EntityProperty("nodes", FoxDataType.EntityPtr, FoxContainerType.DynamicArray)]
        public List<GraphNodeBase> Nodes;

        [EntityProperty("edges", FoxDataType.EntityPtr, FoxContainerType.DynamicArray)]
        public List<GraphEdgeBase> Edges;
    }
}