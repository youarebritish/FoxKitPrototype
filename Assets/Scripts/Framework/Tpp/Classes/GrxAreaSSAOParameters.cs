using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class GrxAreaSSAOParameters : Entity
    {
        [EntityProperty("resolution", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 Resolution;

        [EntityProperty("radius", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Radius;

        [EntityProperty("angleBias", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single AngleBias;

        [EntityProperty("numSteps", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 NumSteps;

        [EntityProperty("numDirections", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 NumDirections;

        [EntityProperty("attenuation", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Attenuation;

        [EntityProperty("contrast", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Contrast;

        [EntityProperty("blurMode", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 BlurMode;

        [EntityProperty("blurRadius", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single BlurRadius;

        [EntityProperty("blurSharpness", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single BlurSharpness;

        [EntityProperty("blurSceneScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single BlurSceneScale;
    }
}
