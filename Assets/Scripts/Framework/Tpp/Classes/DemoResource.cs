using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class DemoResource : Data
    {
        [EntityProperty("enable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Enable;

        [EntityProperty("demoIdentifierName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String DemoIdentifierName;

        [EntityProperty("demoIdentifierKey", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> DemoIdentifierKey;

        [EntityProperty("streamBufferSizeInKbytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 StreamBufferSizeInKbytes;

        [EntityProperty("systemPacketSizeInKbytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 SystemPacketSizeInKbytes;

        [EntityProperty("systemPacketNum", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 SystemPacketNum;

        [EntityProperty("soundPacketSizeInKbytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 SoundPacketSizeInKbytes;

        [EntityProperty("soundPacketNum", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 SoundPacketNum;

        [EntityProperty("demoPacketSizeInKbytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 DemoPacketSizeInKbytes;

        [EntityProperty("demoPacketNum", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 DemoPacketNum;
    }
}
