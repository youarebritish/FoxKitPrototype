using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class SoundPhysicsParameter : Data
    {
        [EntityProperty("hitEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String HitEvent;

        [EntityProperty("rollStartEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String RollStartEvent;

        [EntityProperty("rollEndEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String RollEndEvent;

        [EntityProperty("hitRtpcName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String HitRtpcName;

        [EntityProperty("rollRtpcName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String RollRtpcName;

        [EntityProperty("switchName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String SwitchName;

        [EntityProperty("generalEvent1", FoxDataType.String, FoxContainerType.StaticArray)]
        public String GeneralEvent1;

        [EntityProperty("generalEvent2", FoxDataType.String, FoxContainerType.StaticArray)]
        public String GeneralEvent2;

        [EntityProperty("hitLowerPower", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single HitLowerPower;

        [EntityProperty("hitUpperPower", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single HitUpperPower;

        [EntityProperty("hitIntervalSeconds", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single HitIntervalSeconds;

        [EntityProperty("hitLowerRtpc", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single HitLowerRtpc;

        [EntityProperty("hitUpperRtpc", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single HitUpperRtpc;

        [EntityProperty("rollLowerPower", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RollLowerPower;

        [EntityProperty("rollUpperPower", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RollUpperPower;

        [EntityProperty("rollStartSeconds", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RollStartSeconds;

        [EntityProperty("rollEndSeconds", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RollEndSeconds;

        [EntityProperty("rollLowerRtpc", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RollLowerRtpc;

        [EntityProperty("rollUpperRtpc", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single RollUpperRtpc;
    }
}
