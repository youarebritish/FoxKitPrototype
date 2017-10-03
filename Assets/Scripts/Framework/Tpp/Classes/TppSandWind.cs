using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppSandWind : Data
    {
        [EntityProperty("intensity", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Intensity;

        [EntityProperty("velocity", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Velocity;

        [EntityProperty("amount", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Amount;

        [EntityProperty("textureRepetition", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single TextureRepetition;

        [EntityProperty("intervalDuration", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single IntervalDuration;

        [EntityProperty("phaseScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single PhaseScale;

        [EntityProperty("closeSandRelativeIntensity", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CloseSandRelativeIntensity;

        [EntityProperty("closeSandRelativeVelocity", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CloseSandRelativeVelocity;
    }
}
