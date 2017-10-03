using FoxKit.Framework.Fox;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types;
using System.Collections.Generic;

namespace FoxKit.Framework.Tpp.Classes
{
    [TppClass(ClassCategory.Sound)]
    public class SoundAreaParameter : DataElement<SoundAreaBase>
    {
        [EntityProperty("ambientEvent", FoxDataType.String)]
        public string AmbientEvent;

        [EntityProperty("ambientRtpcName", FoxDataType.String)]
        public string AmbientRtpcName;

        [EntityProperty("ambientRtpcValue", FoxDataType.Float)]
        public float AmbientRtpcValue;

        [EntityProperty("objectRtpcName", FoxDataType.String)]
        public string ObjectRtpcName;

        [EntityProperty("objectRtpcValue", FoxDataType.Float)]
        public float ObjectRtpcValue;

        [EntityProperty("auxSends", FoxDataType.Float, FoxContainerType.StringMap)]
        public Dictionary<string, float> AuxSends;

        [EntityProperty("dryVolume", FoxDataType.Float)]
        public float DryVolume;
    }
}
 