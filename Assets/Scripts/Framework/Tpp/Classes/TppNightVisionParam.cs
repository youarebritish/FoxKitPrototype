using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppNightVisionParam : DataElement<Data>
    {
        [EntityProperty("enable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Enable;

        [EntityProperty("colorCorrectionLUT", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String ColorCorrectionLUT;

        [EntityProperty("exposureCompensation", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ExposureCompensation;

        [EntityProperty("switchOnCompensation", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SwitchOnCompensation;

        [EntityProperty("switchOnEffectTime", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SwitchOnEffectTime;

        [EntityProperty("switchOffCompensation", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SwitchOffCompensation;

        [EntityProperty("switchOffEffectTime", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SwitchOffEffectTime;

        [EntityProperty("tonemapThreshold", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single TonemapThreshold;

        [EntityProperty("tonemapRange", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single TonemapRange;
    }
}
