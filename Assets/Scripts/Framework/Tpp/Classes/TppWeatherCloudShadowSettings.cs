using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppWeatherCloudShadowSettings : Data
    {
        [EntityProperty("enable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Enable;

        [EntityProperty("texture", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String Texture;

        [EntityProperty("textureMappingRange", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single TextureMappingRange;

        [EntityProperty("windInfluence", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single WindInfluence;
    }
}
