using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppPermanentGimmickMortarParameter : DataElement<Data>
    {
        [EntityProperty("rotationLimitLeftRight", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RotationLimitLeftRight;

        [EntityProperty("rotationLimitUp", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RotationLimitUp;

        [EntityProperty("rotationLimitDown", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RotationLimitDown;

        [EntityProperty("defaultShellPartsFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String DefaultShellPartsFile;

        [EntityProperty("flareShellPartsFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String FlareShellPartsFile;
    }
}
