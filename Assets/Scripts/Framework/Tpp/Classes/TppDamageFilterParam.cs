using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppDamageFilterParam : TransformData
    {
        [EntityProperty("burnOutsideColor", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color BurnOutsideColor;

        [EntityProperty("burnMiddleColor", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color BurnMiddleColor;

        [EntityProperty("burnInsideColor", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color BurnInsideColor;

        [EntityProperty("burnHoleColor", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color BurnHoleColor;

        [EntityProperty("burnSpriteSize", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single BurnSpriteSize;

        [EntityProperty("burnSpritePosition", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single BurnSpritePosition;

        [EntityProperty("damageColorCorrectionTextureName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String DamageColorCorrectionTextureName;

        [EntityProperty("injuryColorCorrectionTextureName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String InjuryColorCorrectionTextureName;
    }
}
