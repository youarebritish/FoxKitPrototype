using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class PhxWheelConstraintParam : Entity
    {
        [EntityProperty("defaultPosition", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 DefaultPosition;

        [EntityProperty("defaultRotation", FoxDataType.Quat, FoxContainerType.StaticArray)]
        public Quaternion DefaultRotation;

        [EntityProperty("positionL", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 PositionL;

        [EntityProperty("frontL", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 FrontL;

        [EntityProperty("upL", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 UpL;

        [EntityProperty("wheelPositionOffset", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 WheelPositionOffset;

        [EntityProperty("radius", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Radius;

        [EntityProperty("suspensionLength", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SuspensionLength;

        [EntityProperty("maxSuspensionForce", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaxSuspensionForce;

        [EntityProperty("dampingFactorElong", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DampingFactorElong;

        [EntityProperty("dampingFactorCompress", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DampingFactorCompress;

        [EntityProperty("friction", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Friction;

        [EntityProperty("restitution", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Restitution;

        [EntityProperty("inertia", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Inertia;
    }
}
