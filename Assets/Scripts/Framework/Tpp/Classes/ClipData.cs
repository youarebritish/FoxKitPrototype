using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class ClipData : DataElement<Data>
    {
        [EntityProperty("name", FoxDataType.String, FoxContainerType.StaticArray)]
        public String Name;

        [EntityProperty("cameraName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String CameraName;

        [EntityProperty("startFrame", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 StartFrame;

        [EntityProperty("endFrame", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 EndFrame;

        [EntityProperty("offsetFrame", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 OffsetFrame;
    }
}
