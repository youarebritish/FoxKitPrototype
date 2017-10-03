using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppEspionageRadioLocatorParameter : DataElement<Data>
    {
        [EntityProperty("radioLocatorId", FoxDataType.String, FoxContainerType.StaticArray)]
        public String RadioLocatorId;

        [EntityProperty("minDistance", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MinDistance;

        [EntityProperty("maxDistance", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single MaxDistance;

        [EntityProperty("angle", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single Angle;
    }
}
