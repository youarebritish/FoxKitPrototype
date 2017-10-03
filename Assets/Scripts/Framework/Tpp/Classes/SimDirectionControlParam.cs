using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class SimDirectionControlParam : Entity
    {
        [EntityProperty("refBone", FoxDataType.String, FoxContainerType.StaticArray)]
        public String RefBone;

        [EntityProperty("offset", FoxDataType.Quat, FoxContainerType.StaticArray)]
        public Quaternion Offset;
    }
}
