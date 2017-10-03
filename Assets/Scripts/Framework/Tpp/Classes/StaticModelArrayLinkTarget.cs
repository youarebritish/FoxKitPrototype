using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class StaticModelArrayLinkTarget : Data
    {
        [EntityProperty("staticModelArray", FoxDataType.EntityHandle, FoxContainerType.StaticArray)]
        public Entity StaticModelArray;

        [EntityProperty("arrayIndex", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 ArrayIndex;
    }
}
