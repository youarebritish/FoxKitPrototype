using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class NavxAttributeInfo : DataElement<Data>
    {
        [EntityProperty("name", FoxDataType.String, FoxContainerType.StaticArray)]
        public String Name;

        [EntityProperty("simplificationThreshold", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SimplificationThreshold;
    }
}
