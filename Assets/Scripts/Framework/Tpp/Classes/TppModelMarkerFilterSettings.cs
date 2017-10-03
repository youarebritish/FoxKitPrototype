using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppModelMarkerFilterSettings : Data
    {
        [EntityProperty("texRepeatsNear", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single TexRepeatsNear;

        [EntityProperty("texRepeatsFar", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single TexRepeatsFar;

        [EntityProperty("texRepeatsMin", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single TexRepeatsMin;

        [EntityProperty("texRepeatsMax", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single TexRepeatsMax;

        [EntityProperty("alphas", FoxDataType.Vector3, FoxContainerType.DynamicArray)]
        public List<Vector3> Alphas;

        [EntityProperty("offsets", FoxDataType.Vector3, FoxContainerType.DynamicArray)]
        public List<Vector3> Offsets;

        [EntityProperty("incidences", FoxDataType.Vector3, FoxContainerType.DynamicArray)]
        public List<Vector3> Incidences;
    }
}
