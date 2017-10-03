using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class SoundAreaMember : Data
    {
        [EntityProperty("shapes", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> Shapes;

        [EntityProperty("priority", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Priority;

        [EntityProperty("parameter", FoxDataType.EntityPtr, FoxContainerType.StaticArray)]
        public Entity Parameter;
    }
}
