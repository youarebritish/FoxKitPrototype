using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class PhxVehicleNormalEngine : Data
    {
        [EntityProperty("vehicleAxes", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> VehicleAxes;

        [EntityProperty("torqueDistributions", FoxDataType.Float, FoxContainerType.DynamicArray)]
        public List<Single> TorqueDistributions;

        [EntityProperty("gearRatios", FoxDataType.Float, FoxContainerType.DynamicArray)]
        public List<Single> GearRatios;

        [EntityProperty("vehicleNormalEngineParam", FoxDataType.EntityPtr, FoxContainerType.StaticArray)]
        public Entity VehicleNormalEngineParam;
    }
}
