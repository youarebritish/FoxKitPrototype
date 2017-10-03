using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppAmbientSoundSource : TransformData
    {
        [EntityProperty("eventName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String EventName;

        [EntityProperty("shapes", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> Shapes;

        [EntityProperty("lodRange", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single LodRange;

        [EntityProperty("playRange", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single PlayRange;

        [EntityProperty("volumeRtpc", FoxDataType.String, FoxContainerType.StaticArray)]
        public String VolumeRtpc;

        [EntityProperty("ambientIndex", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte AmbientIndex;
    }
}
