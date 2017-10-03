using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppCombatLocatorSetData : Data
    {
        [EntityProperty("radius", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Radius;

        [EntityProperty("lostSearchRadius", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LostSearchRadius;

        [EntityProperty("locators", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> Locators;
    }
}
