using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class ChildrenIdConvertParameter : DataElement<Data>
    {
        [EntityProperty("injuryId", FoxDataType.String, FoxContainerType.StaticArray)]
        public String InjuryId;

        [EntityProperty("yellowHoodId", FoxDataType.String, FoxContainerType.StaticArray)]
        public String YellowHoodId;

        [EntityProperty("afloId", FoxDataType.String, FoxContainerType.StaticArray)]
        public String AfloId;

        [EntityProperty("shortAfloId", FoxDataType.String, FoxContainerType.StaticArray)]
        public String ShortAfloId;

        [EntityProperty("blackCoatId", FoxDataType.String, FoxContainerType.StaticArray)]
        public String BlackCoatId;

        [EntityProperty("injuryPriority", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte InjuryPriority;

        [EntityProperty("yellowHoodPriority", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte YellowHoodPriority;

        [EntityProperty("afloPriority", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte AfloPriority;

        [EntityProperty("shortAfloPriority", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte ShortAfloPriority;

        [EntityProperty("blackCoatPriority", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte BlackCoatPriority;

        [EntityProperty("enableInjuredChildSpecialization", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean EnableInjuredChildSpecialization;
    }
}
