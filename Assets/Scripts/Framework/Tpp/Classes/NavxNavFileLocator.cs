using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class NavxNavFileLocator : TransformData
    {
        [EntityProperty("sceneName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String SceneName;

        [EntityProperty("worldName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String WorldName;

        [EntityProperty("enable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Enable;

        [EntityProperty("navFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String NavFile;
    }
}
