using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class GameObject : Data
    {
        [EntityProperty("typeName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String TypeName;

        [EntityProperty("groupId", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 GroupId;

        [EntityProperty("totalCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 TotalCount;

        [EntityProperty("realizedCount", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 RealizedCount;

        [EntityProperty("parameters", FoxDataType.EntityPtr, FoxContainerType.StaticArray)]
        public Entity Parameters;
    }
}
