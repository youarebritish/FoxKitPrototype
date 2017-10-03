using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppHandLightLensFlareRoot : TransformData
    {
        [EntityProperty("independentEditMode", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IndependentEditMode;

        [EntityProperty("takeover", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Takeover;

        [EntityProperty("debugFillCheck", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean DebugFillCheck;

        [EntityProperty("needCollisionCheck", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean NeedCollisionCheck;

        [EntityProperty("exposureBlend", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ExposureBlend;

        [EntityProperty("lensFlareName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String LensFlareName;

        [EntityProperty("shapes", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> Shapes;
    }
}
