using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class SimWindControl : DataElement<Data>
    {
        [EntityProperty("bones", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> Bones;

        [EntityProperty("controlParam", FoxDataType.EntityPtr, FoxContainerType.StaticArray)]
        public Entity ControlParam;
    }
}
