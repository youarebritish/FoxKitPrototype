using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class MotherBaseConstructDivisionLocator : TransformData
    {
        [EntityProperty("type", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Type;

        [EntityProperty("isLowModel", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IsLowModel;

        [EntityProperty("staticModels", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> StaticModels;
    }
}
