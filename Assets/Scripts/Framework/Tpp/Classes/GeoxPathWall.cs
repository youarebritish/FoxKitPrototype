using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class GeoxPathWall : TransformData
    {
        [EntityProperty("height", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Height;

        [EntityProperty("isVisibleGeom", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IsVisibleGeom;

        [EntityProperty("faceFlag", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 FaceFlag;

        [EntityProperty("collisionAttributeTags", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> CollisionAttributeTags;
    }
}
