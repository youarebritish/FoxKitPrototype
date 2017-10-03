using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class PhxVehicleAxis : Data
    {
        [EntityProperty("vehicleAxisParam", FoxDataType.EntityPtr, FoxContainerType.StaticArray)]
        public Entity VehicleAxisParam;

        [EntityProperty("wheelConstraintParam", FoxDataType.EntityPtr, FoxContainerType.StaticArray)]
        public Entity WheelConstraintParam;

        [EntityProperty("wheelAssociationUnitParams", FoxDataType.EntityPtr, FoxContainerType.DynamicArray)]
        public List<Entity> WheelAssociationUnitParams;

        [EntityProperty("torqueDistributions", FoxDataType.Float, FoxContainerType.DynamicArray)]
        public List<Single> TorqueDistributions;

        [EntityProperty("gearRatios", FoxDataType.Float, FoxContainerType.DynamicArray)]
        public List<Single> GearRatios;
    }
}
