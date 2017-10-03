using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class NavxFillNavVolume : TransformData
    {
        [EntityProperty("sceneName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String SceneName;

        [EntityProperty("worldName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String WorldName;

        [EntityProperty("attributes", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> Attributes;

        protected override void OnDrawGizmos()
        {
            base.OnDrawGizmos();
            Gizmos.DrawWireCube(transform.position, transform.localScale);
        }
    }
}
