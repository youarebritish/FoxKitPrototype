using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using System.Collections.Generic;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;

namespace FoxKit.Framework.Tpp.Classes
{
    [TppClass(ClassCategory.Sound)]
    public class TppSoundWorld : Data
    {
        [EntityProperty("updateSeconds", FoxDataType.UInt32)]
        public uint UpdateSeconds;

        [EntityProperty("startMorning", FoxDataType.Float)]
        public float StartMorning;

        [EntityProperty("midMorning", FoxDataType.Float)]
        public float MidMorning;

        [EntityProperty("endMorning", FoxDataType.Float)]
        public float EndMorning;

        [EntityProperty("startEvening", FoxDataType.Float)]
        public float StartEvening;

        [EntityProperty("midEvening", FoxDataType.Float)]
        public float MidEvening;

        [EntityProperty("endEvening", FoxDataType.Float)]
        public float EndEvening;

        [EntityProperty("situationEvent", FoxDataType.String)]
        public string SituationEvent;

        [EntityProperty("clockRtpc", FoxDataType.String)]
        public string ClockRtpc;

        [EntityProperty("windVelocityRtpc", FoxDataType.String)]
        public string WindVelocityRtpc;

        [EntityProperty("windDirectionRtpc", FoxDataType.String)]
        public string WindDirectionRtpc;

        [EntityProperty("rainRtpc", FoxDataType.String)]
        public string RainRtpc;

        [EntityProperty("heightRtpc", FoxDataType.String)]
        public string HeightRtpc;

        /// <summary>
        /// No idea what's going on in this property. This is the only StaticArray I see with more than 1 entry.
        /// TODO Fix, figure out wtf is going on
        /// </summary>
        [EntityProperty("ambientParameter", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public FoxEntityLink AmbientParameter;

        [EntityProperty("categoryFpvStateGroup", FoxDataType.String)]
        public string CategoryFpvStateGroup;

        [EntityProperty("categoryFpvStateValue", FoxDataType.String)]
        public string CategoryFpvStateValue;

        [EntityProperty("dashStartEventName", FoxDataType.String)]
        public string DashStartEventName;

        [EntityProperty("dashFinishEventName", FoxDataType.String)]
        public string DashFinishEventName;

        [EntityProperty("blockedObstruction", FoxDataType.Float)]
        public float BlockedObstruction;

        [EntityProperty("blockedOcclusion", FoxDataType.Float)]
        public float BlockedOcclusion;

        [EntityProperty("unlinkedObstruction", FoxDataType.Float)]
        public float UnlinkedObstruction;

        [EntityProperty("unlinkedOcclusion", FoxDataType.Float)]
        public float UnlinkedOcclusion;

        [EntityProperty("interferenceSlope", FoxDataType.Float)]
        public float InterferenceSlope;
    }
}
 