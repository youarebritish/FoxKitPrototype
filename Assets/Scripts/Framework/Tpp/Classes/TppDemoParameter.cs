using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppDemoParameter : DataElement<Data>
    {
        [EntityProperty("pauseEnable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean PauseEnable;

        [EntityProperty("fadeSerchLightEnable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean FadeSerchLightEnable;

        [EntityProperty("fadeDirectionalLightEnable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean FadeDirectionalLightEnable;

        [EntityProperty("fadeSandStormEnable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean FadeSandStormEnable;

        [EntityProperty("sandStormDensityMin", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SandStormDensityMin;

        [EntityProperty("fadeTime", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single FadeTime;

        [EntityProperty("useSetTime", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean UseSetTime;

        [EntityProperty("hour", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Hour;

        [EntityProperty("minute", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Minute;

        [EntityProperty("second", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Second;

        [EntityProperty("weatherType", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 WeatherType;
    }
}
