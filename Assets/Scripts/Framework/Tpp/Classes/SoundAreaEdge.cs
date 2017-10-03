using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class SoundAreaEdge : Data
    {
        [EntityProperty("parameter", FoxDataType.EntityPtr, FoxContainerType.StaticArray)]
        public Entity Parameter;

        [EntityProperty("prevArea", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink PrevArea;

        [EntityProperty("nextArea", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink NextArea;
    }
}
