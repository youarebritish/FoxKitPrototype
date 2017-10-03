using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppWaterRippleViewport : Data
    {
        [EntityProperty("rippleTextureName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String RippleTextureName;

        [EntityProperty("viewportWidth", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 ViewportWidth;

        [EntityProperty("ripplePower", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RipplePower;

        [EntityProperty("debugView", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean DebugView;
    }
}
