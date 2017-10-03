using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class StageLightFadeData : Data
    {
        [EntityProperty("lightGroup", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> LightGroup;

        [EntityProperty("colorList", FoxDataType.Color, FoxContainerType.DynamicArray)]
        public List<Color> ColorList;

        [EntityProperty("requirdTime", FoxDataType.Float, FoxContainerType.DynamicArray)]
        public List<Single> RequirdTime;
    }
}
