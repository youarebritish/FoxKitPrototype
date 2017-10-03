using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppObjectBrushSkeletonModelReserveResource : Data
    {
        [EntityProperty("pluginName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String PluginName;

        [EntityProperty("reserveLodLevel0", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 ReserveLodLevel0;

        [EntityProperty("reserveLodLevel1", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 ReserveLodLevel1;

        [EntityProperty("reserveLodLevel2", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 ReserveLodLevel2;

        [EntityProperty("reserveLodLevel3", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 ReserveLodLevel3;
    }
}
