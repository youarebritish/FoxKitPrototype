using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class PhObjectDesc : Data
    {
        [EntityProperty("bodies", FoxDataType.EntityPtr, FoxContainerType.DynamicArray)]
        public List<Entity> Bodies;

        [EntityProperty("constraints", FoxDataType.EntityPtr, FoxContainerType.DynamicArray)]
        public List<Entity> Constraints;

        [EntityProperty("bodyIndices", FoxDataType.Int32, FoxContainerType.DynamicArray)]
        public List<Int32> BodyIndices;
    }
}
