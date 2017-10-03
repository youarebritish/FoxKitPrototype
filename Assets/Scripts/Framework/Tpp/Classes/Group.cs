using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class Group : Data
    {
        [EntityProperty("parentGroup", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink ParentGroup;

        [EntityProperty("members", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> Members;

        [EntityProperty("deleteFromPackage", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean DeleteFromPackage;
    }
}
