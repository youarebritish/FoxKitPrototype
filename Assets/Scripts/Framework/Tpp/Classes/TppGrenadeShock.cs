using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppGrenadeShock : Data
    {
        [EntityProperty("redConeSaturationDuration", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RedConeSaturationDuration;

        [EntityProperty("greenConeSaturationDuration", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single GreenConeSaturationDuration;

        [EntityProperty("blueConeSaturationDuration", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single BlueConeSaturationDuration;

        [EntityProperty("distortionVelocity", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DistortionVelocity;

        [EntityProperty("distortionIntensity", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DistortionIntensity;

        [EntityProperty("distortionProjectionScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DistortionProjectionScale;

        [EntityProperty("rotationSpeed", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RotationSpeed;
    }
}
