using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class SimClothSettingData : Data
    {
        [EntityProperty("iteration", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Iteration;

        [EntityProperty("mass", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Mass;

        [EntityProperty("velocityDamp", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single VelocityDamp;

        [EntityProperty("airResistance", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single AirResistance;

        [EntityProperty("gravityRate", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single GravityRate;

        [EntityProperty("restoreRate", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RestoreRate;

        [EntityProperty("inertialRate", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single InertialRate;

        [EntityProperty("inertialMax", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single InertialMax;

        [EntityProperty("noHitSkinMesh", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean NoHitSkinMesh;
    }
}
