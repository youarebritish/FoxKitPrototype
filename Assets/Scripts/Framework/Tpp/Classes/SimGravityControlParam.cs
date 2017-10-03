using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class SimGravityControlParam : Entity
    {
        [EntityProperty("customGravity", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 CustomGravity;
    }
}
