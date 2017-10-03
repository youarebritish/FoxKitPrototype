using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppRequestWeatherTagTrapExecDataElement : DataElement<Data>
    {
        [EntityProperty("funcName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String FuncName;

        [EntityProperty("tagName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String TagName;

        [EntityProperty("priority", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Priority;

        [EntityProperty("interpTime", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single InterpTime;
    }
}
