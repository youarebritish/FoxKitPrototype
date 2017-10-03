using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class DesParamData : Data
    {
        [EntityProperty("density", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Density;

        [EntityProperty("friction", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Friction;

        [EntityProperty("restitution", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Restitution;

        [EntityProperty("materialName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String MaterialName;

        [EntityProperty("desCondition", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 DesCondition;

        [EntityProperty("desImpactPowerThreshold", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DesImpactPowerThreshold;

        [EntityProperty("physicalCoefficient", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single PhysicalCoefficient;
    }
}
