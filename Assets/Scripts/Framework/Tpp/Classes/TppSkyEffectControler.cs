using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppSkyEffectControler : Data
    {
        [EntityProperty("cameraLight", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink CameraLight;

        [EntityProperty("hour", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Hour;

        [EntityProperty("minute", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Minute;

        [EntityProperty("second", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Second;
    }
}
