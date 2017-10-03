using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppTrapExecCombatLocatorCallbackDataElement : DataElement<Entity>
    {
        [EntityProperty("funcName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String FuncName;

        [EntityProperty("frontLineName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String FrontLineName;

        [EntityProperty("inactiveLocators", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> InactiveLocators;
    }
}
