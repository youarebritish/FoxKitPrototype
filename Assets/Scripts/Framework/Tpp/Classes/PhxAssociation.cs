using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class PhxAssociation : Data
    {
        [EntityProperty("physicsData", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink PhysicsData;

        [EntityProperty("connections", FoxDataType.EntityPtr, FoxContainerType.StringMap)]
        public Dictionary<string, Entity> Connections;

        [EntityProperty("param", FoxDataType.EntityPtr, FoxContainerType.StaticArray)]
        public Entity Param;
    }
}
