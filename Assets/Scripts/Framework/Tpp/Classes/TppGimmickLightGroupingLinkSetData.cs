using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppGimmickLightGroupingLinkSetData : Data
    {
        [EntityProperty("ownerGimmickList", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> OwnerGimmickList;

        [EntityProperty("gimmickNameList", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> GimmickNameList;

        [EntityProperty("light", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink Light;
    }
}
