using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class SimOnPhysics : Data
    {
        [EntityProperty("objectParam", FoxDataType.EntityPtr, FoxContainerType.StaticArray)]
        public Entity ObjectParam;

        [EntityProperty("engineParam", FoxDataType.EntityPtr, FoxContainerType.StaticArray)]
        public Entity EngineParam;

        [EntityProperty("controls", FoxDataType.EntityPtr, FoxContainerType.DynamicArray)]
        public List<Entity> Controls;

        [EntityProperty("simRootBones", FoxDataType.EntityPtr, FoxContainerType.StringMap)]
        public Dictionary<string, Entity> SimRootBones;

        [EntityProperty("simBones", FoxDataType.EntityPtr, FoxContainerType.StringMap)]
        public Dictionary<string, Entity> SimBones;

        [EntityProperty("simTransBones", FoxDataType.EntityPtr, FoxContainerType.StringMap)]
        public Dictionary<string, Entity> SimTransBones;

        [EntityProperty("simHitBones", FoxDataType.EntityPtr, FoxContainerType.StringMap)]
        public Dictionary<string, Entity> SimHitBones;

        [EntityProperty("formatVersion", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 FormatVersion;

        [EntityProperty("physicsData", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink PhysicsData;
    }
}
