using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppPlayer2Parameter : DataElement<Data>
    {
        [EntityProperty("motionGraphFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String MotionGraphFile;

        [EntityProperty("vfxFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> VfxFiles;

        [EntityProperty("lifeMax", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LifeMax;

        [EntityProperty("lifeRecoveryPerSecond", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LifeRecoveryPerSecond;

        [EntityProperty("respawnTime", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RespawnTime;

        [EntityProperty("clipCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 ClipCount;

        [EntityProperty("fireInterval", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single FireInterval;

        [EntityProperty("lifeRecoveryCooldownTimer", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LifeRecoveryCooldownTimer;

        [EntityProperty("partsType", FoxDataType.String, FoxContainerType.StaticArray)]
        public String PartsType;

        [EntityProperty("TODO_trapTags", FoxDataType.UInt8, FoxContainerType.StringMap)]
        public Dictionary<string, Byte> TODO_trapTags;
    }
}
