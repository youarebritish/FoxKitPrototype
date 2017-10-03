using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppPermanentGimmickData : Data
    {
        [EntityProperty("partsFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String PartsFile;

        [EntityProperty("locaterFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String LocaterFile;

        [EntityProperty("parameters", FoxDataType.EntityPtr, FoxContainerType.StaticArray)]
        public Entity Parameters;

        [EntityProperty("flags1", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Flags1;

        [EntityProperty("flags2", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Flags2;
    }
}
