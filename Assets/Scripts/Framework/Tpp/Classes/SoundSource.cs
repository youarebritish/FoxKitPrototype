using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class SoundSource : TransformData
    {
        [EntityProperty("eventName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String EventName;

        [EntityProperty("shapes", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> Shapes;

        [EntityProperty("lodRange", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LodRange;

        [EntityProperty("playRange", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single PlayRange;

        protected void OnDrawGizmosSelected()
        {
            base.OnDrawGizmos();
            Gizmos.DrawWireSphere(transform.position, PlayRange);
        }
    }
}
