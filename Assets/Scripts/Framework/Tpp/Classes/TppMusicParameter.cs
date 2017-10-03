using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppMusicParameter : Data
    {
        [EntityProperty("tag", FoxDataType.String, FoxContainerType.StaticArray)]
        public String Tag;

        [EntityProperty("playEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String PlayEvent;

        [EntityProperty("daySwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String DaySwitchEvent;

        [EntityProperty("nightSwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String NightSwitchEvent;

        [EntityProperty("dangerEasySwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String DangerEasySwitchEvent;

        [EntityProperty("dangerOuterSwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String DangerOuterSwitchEvent;

        [EntityProperty("dangerHardSwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String DangerHardSwitchEvent;

        [EntityProperty("dangerEasyLostSwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String DangerEasyLostSwitchEvent;

        [EntityProperty("dangerOuterLostSwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String DangerOuterLostSwitchEvent;

        [EntityProperty("dangerHardLostSwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String DangerHardLostSwitchEvent;

        [EntityProperty("dangerEvasionSwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String DangerEvasionSwitchEvent;

        [EntityProperty("dangerStrongSwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String DangerStrongSwitchEvent;

        [EntityProperty("safetyReflexSwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String SafetyReflexSwitchEvent;

        [EntityProperty("safetyNeutralToSneakSwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String SafetyNeutralToSneakSwitchEvent;

        [EntityProperty("safetySneakSwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String SafetySneakSwitchEvent;

        [EntityProperty("safetyCautionSwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String SafetyCautionSwitchEvent;

        [EntityProperty("safetyNoticeSwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String SafetyNoticeSwitchEvent;

        [EntityProperty("safetyCautionNoticeSwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String SafetyCautionNoticeSwitchEvent;

        [EntityProperty("safetyAlertToCautionSwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String SafetyAlertToCautionSwitchEvent;

        [EntityProperty("neutralSwitchEvent", FoxDataType.String, FoxContainerType.StaticArray)]
        public String NeutralSwitchEvent;
    }
}
