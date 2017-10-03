using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class PhBallsocketConstraintParam : Entity
    {
        [EntityProperty("defaultPosition", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 DefaultPosition;

        [EntityProperty("limitedFlag", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean LimitedFlag;

        [EntityProperty("refA", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 RefA;

        [EntityProperty("refB", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 RefB;

        [EntityProperty("limit", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Limit;

        [EntityProperty("springFlag", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean SpringFlag;

        [EntityProperty("springRefCustomFlag", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean SpringRefCustomFlag;

        [EntityProperty("springRef", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 SpringRef;

        [EntityProperty("springConstant", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SpringConstant;

        [EntityProperty("flexibility", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Flexibility;

        [EntityProperty("stopTwistFlag", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean StopTwistFlag;
    }
}
