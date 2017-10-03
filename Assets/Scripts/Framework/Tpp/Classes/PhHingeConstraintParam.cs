using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class PhHingeConstraintParam : Entity
    {
        [EntityProperty("defaultPosition", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 DefaultPosition;

        [EntityProperty("axis", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 Axis;

        [EntityProperty("limitedFlag", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean LimitedFlag;

        [EntityProperty("limitHi", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LimitHi;

        [EntityProperty("limitLo", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LimitLo;
    }
}
