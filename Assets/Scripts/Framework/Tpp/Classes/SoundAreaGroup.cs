using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class SoundAreaGroup : SoundAreaBase
    {
        [EntityProperty("priority", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Priority;
        
        [EntityProperty("members", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> Members;

        [EntityProperty("edges", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> Edges;
    }
}
