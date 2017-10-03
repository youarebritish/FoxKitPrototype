using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppCombatLocatorData : TransformData
    {
        [EntityProperty("radius", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Radius;

        [EntityProperty("lostSearchRadius", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LostSearchRadius;

        [EntityProperty("isUseWaitPrioirty", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IsUseWaitPrioirty;

        [EntityProperty("isReinforcePoint", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IsReinforcePoint;

        [EntityProperty("memberCount", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte MemberCount;

        [EntityProperty("memberCountFront", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte MemberCountFront;

        [EntityProperty("subLocators", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> SubLocators;
    }
}
