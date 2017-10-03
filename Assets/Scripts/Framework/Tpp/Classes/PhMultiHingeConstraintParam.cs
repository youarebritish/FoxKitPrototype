using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class PhMultiHingeConstraintParam : Entity
    {
        [EntityProperty("defaultPosition", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 DefaultPosition;

        [EntityProperty("axis", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 Axis;

        [EntityProperty("limitedFlag", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean LimitedFlag;

        [EntityProperty("isPoweredFlag", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IsPoweredFlag;

        [EntityProperty("limitHi", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LimitHi;

        [EntityProperty("limitLo", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LimitLo;

        [EntityProperty("controlType", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 ControlType;

        [EntityProperty("velocityMax", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single VelocityMax;

        [EntityProperty("torqueMax", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single TorqueMax;

        [EntityProperty("targetTheta", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single TargetTheta;

        [EntityProperty("targetVelocity", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single TargetVelocity;

        [EntityProperty("velocityRate", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single VelocityRate;
    }
}
