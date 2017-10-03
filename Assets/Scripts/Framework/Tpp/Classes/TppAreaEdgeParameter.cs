using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppAreaEdgeParameter : DataElement<Data>
    {
        [EntityProperty("fadeTime", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 FadeTime;

        [EntityProperty("connectedClearObstruction", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ConnectedClearObstruction;

        [EntityProperty("connectedClearOcclusion", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ConnectedClearOcclusion;

        [EntityProperty("connectedBlockedObstruction", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ConnectedBlockedObstruction;

        [EntityProperty("connectedBlockedOcclusion", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single ConnectedBlockedOcclusion;
    }
}
