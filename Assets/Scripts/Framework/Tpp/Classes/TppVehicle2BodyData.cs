using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppVehicle2BodyData : Data
    {
        [EntityProperty("vehicleTypeIndex", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte VehicleTypeIndex;

        [EntityProperty("proxyVehicleTypeIndex", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte ProxyVehicleTypeIndex;

        [EntityProperty("bodyImplTypeIndex", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte BodyImplTypeIndex;

        [EntityProperty("partsFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String PartsFile;

        [EntityProperty("bodyInstanceCount", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte BodyInstanceCount;

        [EntityProperty("weaponParams", FoxDataType.EntityPtr, FoxContainerType.DynamicArray)]
        public List<Entity> WeaponParams;

        [EntityProperty("fovaFiles", FoxDataType.FilePtr, FoxContainerType.DynamicArray)]
        public List<String> FovaFiles;
    }
}
