using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class GeoxCollisionPyraidFreeShape : TransformData
    {
        [EntityProperty("collisionCategory", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 CollisionCategory;

        [EntityProperty("collisionMaterial", FoxDataType.String, FoxContainerType.StaticArray)]
        public String CollisionMaterial;

        [EntityProperty("collisionAttributeNames", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> CollisionAttributeNames;

        [EntityProperty("points", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 Points;
    }
}
