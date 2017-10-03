using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppLadderData : TransformData
    {
        [EntityProperty("numSteps", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 NumSteps;

        [EntityProperty("tacticalActionId", FoxDataType.String, FoxContainerType.StaticArray)]
        public String TacticalActionId;

        [EntityProperty("entryPoints", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> EntryPoints;
    }
}
