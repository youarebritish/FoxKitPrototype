using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppPermanentGimmickEventAnimationParameter : DataElement<Data>
    {
        [EntityProperty("flag1", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Flag1;

        [EntityProperty("defaultAnimPath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String DefaultAnimPath;

        [EntityProperty("eventAnimPath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String EventAnimPath;

        [EntityProperty("fadeTime", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single FadeTime;
    }
}
