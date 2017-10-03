using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppDamageFilterExposure : Data
    {
        [EntityProperty("exposureCompensation", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ExposureCompensation;

        [EntityProperty("minExposure", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MinExposure;

        [EntityProperty("maxExposure", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaxExposure;

        [EntityProperty("beatExposureCompensation", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single BeatExposureCompensation;

        [EntityProperty("minBeatInterval", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MinBeatInterval;

        [EntityProperty("maxBeatInterval", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaxBeatInterval;
    }
}
