using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppVehicle2AttachmentData : Data
    {
        [EntityProperty("vehicleTypeCode", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte VehicleTypeCode;

        [EntityProperty("attachmentImplTypeIndex", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte AttachmentImplTypeIndex;

        [EntityProperty("attachmentFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String AttachmentFile;

        [EntityProperty("attachmentInstanceCount", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte AttachmentInstanceCount;

        [EntityProperty("bodyCnpName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String BodyCnpName;

        [EntityProperty("attachmentBoneName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String AttachmentBoneName;

        [EntityProperty("weaponParams", FoxDataType.EntityPtr, FoxContainerType.DynamicArray)]
        public List<Entity> WeaponParams;
    }
}
