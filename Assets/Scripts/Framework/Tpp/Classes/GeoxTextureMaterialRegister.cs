using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class GeoxTextureMaterialRegister : Data
    {
        [EntityProperty("materialLink", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink MaterialLink;

        [EntityProperty("collisionMaterialName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String CollisionMaterialName;

        [EntityProperty("collisionColorName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String CollisionColorName;
    }
}
