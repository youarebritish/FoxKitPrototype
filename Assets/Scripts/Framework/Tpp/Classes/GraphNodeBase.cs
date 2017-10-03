using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public abstract class GraphNodeBase : DataElement<PathBase>
    {
        [EntityProperty("position", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 Position;

        [EntityProperty("inlinks", FoxDataType.EntityHandle, FoxContainerType.DynamicArray)]
        public List<GraphEdgeBase> Inlinks;

        [EntityProperty("outlinks", FoxDataType.EntityHandle, FoxContainerType.DynamicArray)]
        public List<GraphEdgeBase> Outlinks;

        public override void OnLoaded()
        {
            base.OnLoaded();
            transform.position = Position;
        }
    }
}