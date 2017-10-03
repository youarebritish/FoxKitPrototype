using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppAmbientParameter : Data
    {
        [EntityProperty("ambientEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String AmbientEvent;

        [EntityProperty("objectRtpcName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String ObjectRtpcName;

        [EntityProperty("objectRtpcValue", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ObjectRtpcValue;

        [EntityProperty("auxSends", FoxDataType.Float, FoxContainerType.StringMap)]
        public Dictionary<string, Single> AuxSends;

        [EntityProperty("dryVolume", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single DryVolume;
    }
}
