using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class PhRigidBodyParam : Entity
    {
        [EntityProperty("defaultPosition", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 DefaultPosition;

        [EntityProperty("defaultRotation", FoxDataType.Quat, FoxContainerType.StaticArray)]
        public Quaternion DefaultRotation;

        [EntityProperty("mass", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Mass;

        [EntityProperty("friction", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Friction;

        [EntityProperty("restitution", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Restitution;

        [EntityProperty("maxLinearVelocity", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaxLinearVelocity;

        [EntityProperty("maxAngularVelocity", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaxAngularVelocity;

        [EntityProperty("linearVelocityDamp", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LinearVelocityDamp;

        [EntityProperty("angularVelocityDamp", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single AngularVelocityDamp;

        [EntityProperty("permittedDepth", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single PermittedDepth;

        [EntityProperty("sleepEnable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean SleepEnable;

        [EntityProperty("sleepLinearVelocityTh", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SleepLinearVelocityTh;

        [EntityProperty("sleepAngularVelocityTh", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SleepAngularVelocityTh;

        [EntityProperty("sleepTimeTh", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SleepTimeTh;

        [EntityProperty("collisionGroup", FoxDataType.UInt16, FoxContainerType.StaticArray)]
        public UInt16 CollisionGroup;

        [EntityProperty("collisionType", FoxDataType.UInt16, FoxContainerType.StaticArray)]
        public UInt16 CollisionType;

        [EntityProperty("collisionId", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 CollisionId;

        [EntityProperty("centerOfMassOffset", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 CenterOfMassOffset;

        [EntityProperty("motionType", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 MotionType;

        [EntityProperty("material", FoxDataType.String, FoxContainerType.StaticArray)]
        public String Material;

        [EntityProperty("isNoGravity", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IsNoGravity;
    }
}
