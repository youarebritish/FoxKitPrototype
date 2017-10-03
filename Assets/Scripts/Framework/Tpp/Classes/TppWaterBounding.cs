using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppWaterBounding : TransformData
    {
        [EntityProperty("enableRotate", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean EnableRotate;

        [EntityProperty("debugDraw", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean DebugDraw;

        [EntityProperty("type", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 Type;

        protected override void OnDrawGizmos()
        {
            base.OnDrawGizmos();
            Gizmos.DrawWireCube(transform.position, transform.localScale);
        }
    }
}
