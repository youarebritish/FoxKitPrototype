using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppMarker2LocatorParameter : DataElement<Data>
    {
        [EntityProperty("markerType", FoxDataType.String, FoxContainerType.StaticArray)]
        public String MarkerType;

        [EntityProperty("markerId", FoxDataType.String, FoxContainerType.StaticArray)]
        public String MarkerId;
    }
}
