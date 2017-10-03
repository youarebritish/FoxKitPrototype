using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppLensFlareMaterial : Data
    {
        [EntityProperty("texture", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String Texture;

        [EntityProperty("arcAlphaField", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink ArcAlphaField;

        [EntityProperty("arcAlphaFadeAngle", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ArcAlphaFadeAngle;

        [EntityProperty("arcAlphaBaseAngle", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ArcAlphaBaseAngle;

        [EntityProperty("maskShape", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink MaskShape;

        [EntityProperty("debugDrawMaskShape", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean DebugDrawMaskShape;
    }
}
