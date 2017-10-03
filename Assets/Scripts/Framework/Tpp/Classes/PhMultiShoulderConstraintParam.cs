using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class PhMultiShoulderConstraintParam : Entity
    {
        [EntityProperty("defaultPosition", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 DefaultPosition;

        [EntityProperty("refVec0", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 RefVec0;

        [EntityProperty("refVec1", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 RefVec1;

        [EntityProperty("refLimit0", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RefLimit0;

        [EntityProperty("refLimit1", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RefLimit1;

        [EntityProperty("velocityMax", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single VelocityMax;

        [EntityProperty("torqueMax", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single TorqueMax;

        [EntityProperty("velocityRate", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single VelocityRate;

        [EntityProperty("isPoweredFlag", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IsPoweredFlag;
    }
}
