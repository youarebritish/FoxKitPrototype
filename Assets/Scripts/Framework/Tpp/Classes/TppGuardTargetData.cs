using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppGuardTargetData : TransformData
    {
        [EntityProperty("radius", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Radius;

        [EntityProperty("memberCount", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte MemberCount;

        [EntityProperty("aimPoints", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> AimPoints;
    }
}
