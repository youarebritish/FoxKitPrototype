using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class SimAssociationUnit : DataElement<Entity>
    {
        [EntityProperty("body", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink Body;

        [EntityProperty("constraint", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink Constraint;

        [EntityProperty("bodyOffsetPos", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 BodyOffsetPos;

        [EntityProperty("constraintOffsetPos", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 ConstraintOffsetPos;

        [EntityProperty("offsetRot", FoxDataType.Quat, FoxContainerType.StaticArray)]
        public Quaternion OffsetRot;

        [EntityProperty("param", FoxDataType.EntityPtr, FoxContainerType.StaticArray)]
        public Entity Param;
    }
}
