using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class DecalArray : TransformData
    {
        [EntityProperty("material", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink Material;

        [EntityProperty("projectionMode", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 ProjectionMode;

        [EntityProperty("nearClipScale", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single NearClipScale;

        [EntityProperty("projectionTarget", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 ProjectionTarget;

        [EntityProperty("repeatU", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RepeatU;

        [EntityProperty("repeatV", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RepeatV;

        [EntityProperty("transparency", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Transparency;

        [EntityProperty("polygonDataSource", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 PolygonDataSource;

        [EntityProperty("drawRejectionLevel", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 DrawRejectionLevel;

        [EntityProperty("drawRejectionDegree", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DrawRejectionDegree;

        [EntityProperty("decalFlags", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 DecalFlags;

        [EntityProperty("scales", FoxDataType.Vector3, FoxContainerType.DynamicArray)]
        public List<Vector3> Scales;

        [EntityProperty("rotations", FoxDataType.Quat, FoxContainerType.DynamicArray)]
        public List<Quaternion> Rotations;

        [EntityProperty("translations", FoxDataType.Vector3, FoxContainerType.DynamicArray)]
        public List<Vector3> Translations;

        [EntityProperty("targets", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> Targets;

        [EntityProperty("targetIndices", FoxDataType.UInt32, FoxContainerType.DynamicArray)]
        public List<UInt32> TargetIndices;

        [EntityProperty("targetStartIndices", FoxDataType.UInt32, FoxContainerType.DynamicArray)]
        public List<UInt32> TargetStartIndices;

        [EntityProperty("renderingPriorities", FoxDataType.Int32, FoxContainerType.DynamicArray)]
        public List<Int32> RenderingPriorities;
    }
}
