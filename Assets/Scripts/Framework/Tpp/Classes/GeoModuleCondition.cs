using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class GeoModuleCondition : TransformData
    {
        [EntityProperty("trapCategory", FoxDataType.String, FoxContainerType.StaticArray)]
        public String TrapCategory;

        [EntityProperty("trapPriority", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 TrapPriority;

        [EntityProperty("enable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Enable;

        [EntityProperty("isOnce", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IsOnce;

        [EntityProperty("isAndCheck", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IsAndCheck;

        [EntityProperty("checkFuncNames", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> CheckFuncNames;

        [EntityProperty("execFuncNames", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> ExecFuncNames;

        [EntityProperty("checkCallbackDataElements", FoxDataType.EntityPtr, FoxContainerType.DynamicArray)]
        public List<Entity> CheckCallbackDataElements;

        [EntityProperty("execCallbackDataElements", FoxDataType.EntityPtr, FoxContainerType.DynamicArray)]
        public List<Entity> ExecCallbackDataElements;
    }
}
