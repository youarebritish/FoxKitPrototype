using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppRainFilterInterrupt : Data
    {
        [EntityProperty("planeMatrices", FoxDataType.Matrix4, FoxContainerType.DynamicArray)]
        public List<Matrix4x4> PlaneMatrices;

        [EntityProperty("maskTextures", FoxDataType.Path, FoxContainerType.DynamicArray)]
        public List<String> MaskTextures;

        [EntityProperty("interruptFlags", FoxDataType.UInt32, FoxContainerType.DynamicArray)]
        public List<UInt32> InterruptFlags;

        [EntityProperty("levels", FoxDataType.UInt32, FoxContainerType.DynamicArray)]
        public List<UInt32> Levels;
    }
}
