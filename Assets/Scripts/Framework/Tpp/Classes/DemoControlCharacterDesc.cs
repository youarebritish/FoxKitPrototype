using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class DemoControlCharacterDesc : DataElement<Data>
    {
        [EntityProperty("characterId", FoxDataType.String, FoxContainerType.StaticArray)]
        public String CharacterId;

        [EntityProperty("releaseGroupName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String ReleaseGroupName;

        [EntityProperty("releaseTag", FoxDataType.String, FoxContainerType.StaticArray)]
        public String ReleaseTag;

        [EntityProperty("controlledAtStart", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean ControlledAtStart;

        [EntityProperty("translation", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 Translation;

        [EntityProperty("rotation", FoxDataType.Quat, FoxContainerType.StaticArray)]
        public Quaternion Rotation;

        [EntityProperty("startGroupName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String StartGroupName;

        [EntityProperty("startTag", FoxDataType.String, FoxContainerType.StaticArray)]
        public String StartTag;

        [EntityProperty("startTranslation", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 StartTranslation;

        [EntityProperty("startRotation", FoxDataType.Quat, FoxContainerType.StaticArray)]
        public Quaternion StartRotation;
    }
}
