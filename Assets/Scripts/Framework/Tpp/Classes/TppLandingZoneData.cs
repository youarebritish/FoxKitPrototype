using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppLandingZoneData : TransformData
    {
        [EntityProperty("approachRoute", FoxDataType.String, FoxContainerType.StaticArray)]
        public String ApproachRoute;

        [EntityProperty("returnRoute", FoxDataType.String, FoxContainerType.StaticArray)]
        public String ReturnRoute;
    }
}
