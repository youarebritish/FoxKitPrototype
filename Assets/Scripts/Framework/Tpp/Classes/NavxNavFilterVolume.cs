using FoxKit.Framework.Fox;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types;
using System.Collections.Generic;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    [TppClass(ClassCategory.Navx)]
    public class NavxNavFilterVolume : PathBase
    {
        [EntityProperty("topPos", FoxDataType.Vector3)]
        public Vector3 TopPos;

        [EntityProperty("worldName", FoxDataType.String)]
        public string WorldName;

        protected void OnDrawGizmosSelected()
        {
            foreach(var edge in Edges)
            {
                Gizmos.DrawLine(edge.PrevNode.transform.position, edge.NextNode.transform.position);
                Gizmos.DrawLine(edge.PrevNode.transform.position + TopPos, edge.NextNode.transform.position + TopPos);
                Gizmos.DrawLine(edge.PrevNode.transform.position, edge.PrevNode.transform.position + TopPos);
            }
        }
    }
}
 
 