using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TrapCheckCharacterFilterParam : DataElement<Entity>
    {
        [EntityProperty("funcName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String FuncName;

        [EntityProperty("flag", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Flag;
    }
}
