using FoxKit.Framework.Fox;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;
using System.Collections.Generic;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    [TppClass(ClassCategory.TppEffect)]
    public class TppStar : TransformData
    {
        [EntityProperty("enable", FoxDataType.Bool)]
        public bool Enable;

        [EntityProperty("color", FoxDataType.Color)]
        public Color Color;

        [EntityProperty("intensity", FoxDataType.Float)]
        public float Intensity;

        [EntityProperty("direction", FoxDataType.Float)]
        public float Direction;

        [EntityProperty("bgModelName", FoxDataType.String)]
        public string BgModelName;

        [EntityProperty("modelNameArray", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<string> ModelNameArray;

        [EntityProperty("nameArray", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<string> NameArray;

        [EntityProperty("latitudeArray", FoxDataType.Float, FoxContainerType.DynamicArray)]
        public List<float> LatitudeArray;

        [EntityProperty("longitudeArray", FoxDataType.Float, FoxContainerType.DynamicArray)]
        public List<float> LongitudeArray;

        [EntityProperty("scaleArray", FoxDataType.Float, FoxContainerType.DynamicArray)]
        public List<float> ScaleArray;
    }
}
 
 