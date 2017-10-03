using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class PhVehicleNormalEngineParam : Entity
    {
        [EntityProperty("specPointAngularVelocity", FoxDataType.Float, FoxContainerType.DynamicArray)]
        public List<Single> SpecPointAngularVelocity;

        [EntityProperty("specPointTorque", FoxDataType.Float, FoxContainerType.DynamicArray)]
        public List<Single> SpecPointTorque;

        [EntityProperty("specPointBreakTorque", FoxDataType.Float, FoxContainerType.DynamicArray)]
        public List<Single> SpecPointBreakTorque;
    }
}
