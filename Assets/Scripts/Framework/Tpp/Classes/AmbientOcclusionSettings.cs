using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class AmbientOcclusionSettings : Data
    {
        [EntityProperty("method", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 Method;

        [EntityProperty("attachment", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 Attachment;

        [EntityProperty("lineSSAOParameters", FoxDataType.EntityPtr, FoxContainerType.StaticArray)]
        public Entity LineSSAOParameters;

        [EntityProperty("areaSSAOParameters", FoxDataType.EntityPtr, FoxContainerType.StaticArray)]
        public Entity AreaSSAOParameters;
    }
}
