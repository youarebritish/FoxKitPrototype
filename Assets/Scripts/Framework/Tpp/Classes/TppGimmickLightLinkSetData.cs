using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppGimmickLightLinkSetData : Data
    {
        [EntityProperty("numLightGimmick", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 NumLightGimmick;

        [EntityProperty("ownerGimmick", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink OwnerGimmick;

        [EntityProperty("lightList", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> LightList;
    }
}
