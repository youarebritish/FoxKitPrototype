using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class MotherBaseConstructLocator : TransformData
    {
        [EntityProperty("type", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 Type;

        [EntityProperty("index", FoxDataType.UInt16, FoxContainerType.StaticArray)]
        public UInt16 Index;

        [EntityProperty("clusterId", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte ClusterId;

        [EntityProperty("isLowModel", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IsLowModel;

        [EntityProperty("staticModels", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> StaticModels;
    }
}
