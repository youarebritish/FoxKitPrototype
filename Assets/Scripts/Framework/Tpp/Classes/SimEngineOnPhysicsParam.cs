using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class SimEngineOnPhysicsParam : Entity
    {
        [EntityProperty("isEnableGeoCheck", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IsEnableGeoCheck;

        [EntityProperty("convertMoveToWind", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean ConvertMoveToWind;

        [EntityProperty("minLodLevel", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 MinLodLevel;

        [EntityProperty("maxLodLevel", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 MaxLodLevel;
    }
}
