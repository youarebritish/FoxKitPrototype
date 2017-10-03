using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class LevelingTerrain : TransformData
    {
        [EntityProperty("type", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 Type;

        [EntityProperty("radius", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 Radius;

        [EntityProperty("mixAreaRadius", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 MixAreaRadius;

        protected void OnDrawGizmosSelected()
        {
            Gizmos.DrawWireSphere(transform.position, MixAreaRadius);
        }
    }
}
