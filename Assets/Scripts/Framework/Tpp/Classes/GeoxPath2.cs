using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class GeoxPath2 : PathBase
    {
        [EntityProperty("selectIndex", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 SelectIndex;

        [EntityProperty("enable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Enable;

        [EntityProperty("tags", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> Tags;

        protected void OnDrawGizmosSelected()
        {
            // Draw bottom
            foreach (var edge in Edges)
            {
                Gizmos.DrawLine(edge.PrevNode.transform.position, edge.NextNode.transform.position);
            }
        }
    }
}
