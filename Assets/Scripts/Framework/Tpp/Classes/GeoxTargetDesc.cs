using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class GeoxTargetDesc : Data
    {
        [EntityProperty("posArray", FoxDataType.Vector3, FoxContainerType.DynamicArray)]
        public List<Vector3> PosArray;

        [EntityProperty("scaleArray", FoxDataType.Vector3, FoxContainerType.DynamicArray)]
        public List<Vector3> ScaleArray;

        [EntityProperty("rotArray", FoxDataType.Quat, FoxContainerType.DynamicArray)]
        public List<Quaternion> RotArray;

        [EntityProperty("primTypeArray", FoxDataType.UInt32, FoxContainerType.DynamicArray)]
        public List<UInt32> PrimTypeArray;

        [EntityProperty("systemAttributeArray", FoxDataType.UInt64, FoxContainerType.DynamicArray)]
        public List<UInt64> SystemAttributeArray;

        [EntityProperty("throughValueArray", FoxDataType.UInt32, FoxContainerType.DynamicArray)]
        public List<UInt32> ThroughValueArray;

        [EntityProperty("flagArray", FoxDataType.UInt32, FoxContainerType.DynamicArray)]
        public List<UInt32> FlagArray;

        [EntityProperty("categoryTag", FoxDataType.String, FoxContainerType.StaticArray)]
        public String CategoryTag;

        [EntityProperty("nameArray", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> NameArray;

        [EntityProperty("attachSkeletonArray", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> AttachSkeletonArray;

        [EntityProperty("groupArray", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> GroupArray;

        [EntityProperty("objIndexForgroupTagArray", FoxDataType.UInt32, FoxContainerType.DynamicArray)]
        public List<UInt32> ObjIndexForgroupTagArray;

        [EntityProperty("applicationDataLinkArray", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> ApplicationDataLinkArray;
    }
}
