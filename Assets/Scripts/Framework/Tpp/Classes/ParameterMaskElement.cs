using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class ParameterMaskElement : DataElement<FacialMaskElement>
    {
        [EntityProperty("unitNameList", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> UnitNameList;

        [EntityProperty("nodeName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String NodeName;
    }
}
