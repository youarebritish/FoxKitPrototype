using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppPrimRiverModel : Data
    {
        [EntityProperty("primRiverGroupName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String PrimRiverGroupName;

        [EntityProperty("visibility", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Visibility;

        [EntityProperty("depthBlendLength", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DepthBlendLength;

        [EntityProperty("raise", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Raise;

        [EntityProperty("staticModels", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> StaticModels;
    }
}
