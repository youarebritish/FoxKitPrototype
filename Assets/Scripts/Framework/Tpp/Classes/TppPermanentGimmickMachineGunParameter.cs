using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppPermanentGimmickMachineGunParameter : DataElement<Data>
    {
        [EntityProperty("maxYAxisAngle", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaxYAxisAngle;

        [EntityProperty("minYAxisAngle", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MinYAxisAngle;

        [EntityProperty("maxXAxisAngle", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaxXAxisAngle;

        [EntityProperty("minXAxisAngle", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MinXAxisAngle;

        [EntityProperty("weaponPartsFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String WeaponPartsFile;

        [EntityProperty("flags1", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Flags1;
    }
}
