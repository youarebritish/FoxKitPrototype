using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppVehicle2WeaponParameter : DataElement<Entity>
    {
        [EntityProperty("attackId", FoxDataType.String, FoxContainerType.StaticArray)]
        public String AttackId;

        [EntityProperty("equipId", FoxDataType.String, FoxContainerType.StaticArray)]
        public String EquipId;

        [EntityProperty("bulletId", FoxDataType.String, FoxContainerType.StaticArray)]
        public String BulletId;

        [EntityProperty("weaponImplTypeIndex", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte WeaponImplTypeIndex;

        [EntityProperty("fireInterval", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single FireInterval;

        [EntityProperty("weaponFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String WeaponFile;

        [EntityProperty("ammoFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String AmmoFile;

        [EntityProperty("ownerCnpName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String OwnerCnpName;

        [EntityProperty("weaponBoneName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String WeaponBoneName;

        [EntityProperty("turretBoneName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String TurretBoneName;

        [EntityProperty("barrelBoneName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String BarrelBoneName;

        [EntityProperty("minPitch", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MinPitch;

        [EntityProperty("maxPitch", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaxPitch;

        [EntityProperty("rotSpeed", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RotSpeed;
    }
}
