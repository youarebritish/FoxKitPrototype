using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppLensFlareShapeCircle : TransformData
    {
        [EntityProperty("material", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink Material;

        [EntityProperty("width", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Width;

        [EntityProperty("height", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Height;

        [EntityProperty("baseColor", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color BaseColor;

        [EntityProperty("offsetType", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 OffsetType;

        [EntityProperty("offsetScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single OffsetScale;

        [EntityProperty("baseOffsetX", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single BaseOffsetX;

        [EntityProperty("baseOffsetY", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single BaseOffsetY;

        [EntityProperty("rotateType", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 RotateType;

        [EntityProperty("baseRotate", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single BaseRotate;

        [EntityProperty("screenSpaceRotSpeedX", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ScreenSpaceRotSpeedX;

        [EntityProperty("screenSpaceRotSpeedY", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ScreenSpaceRotSpeedY;

        [EntityProperty("screenSpaceRotField", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink ScreenSpaceRotField;

        [EntityProperty("scaleFieldX", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink ScaleFieldX;

        [EntityProperty("scaleFieldY", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink ScaleFieldY;

        [EntityProperty("scaleFieldPickSunPositionFlag", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean ScaleFieldPickSunPositionFlag;

        [EntityProperty("alphaField", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink AlphaField;

        [EntityProperty("alphaFieldPickSunPositionFlag", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean AlphaFieldPickSunPositionFlag;

        [EntityProperty("shieldFadeOutTime", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ShieldFadeOutTime;

        [EntityProperty("shieldFadeInTime", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ShieldFadeInTime;

        [EntityProperty("angleScaleGraphX", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink AngleScaleGraphX;

        [EntityProperty("angleScaleGraphY", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink AngleScaleGraphY;

        [EntityProperty("angleAlphaGraph", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink AngleAlphaGraph;

        [EntityProperty("distanceScaling", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 DistanceScaling;

        [EntityProperty("limitDistance", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LimitDistance;

        [EntityProperty("notDrawMultiple", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean NotDrawMultiple;

        [EntityProperty("seName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String SeName;

        [EntityProperty("seCallThreshold", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single SeCallThreshold;

        [EntityProperty("scaleOnZoom", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean ScaleOnZoom;

        [EntityProperty("outerScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single OuterScale;

        [EntityProperty("innerScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single InnerScale;

        [EntityProperty("divideNum", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 DivideNum;
    }
}
