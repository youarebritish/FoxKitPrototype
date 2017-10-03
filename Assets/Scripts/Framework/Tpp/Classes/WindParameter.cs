using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using UnityEditor;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class WindParameter : DataElement<WindGlobal>
    {
        [EntityProperty("decayRate", FoxDataType.Float)]
        public float DecayRate;

        [EntityProperty("velocity", FoxDataType.Vector3)]
        public Vector3 Velocity;

        [EntityProperty("speedTurbulentRate", FoxDataType.Float)]
        public float SpeedTurbulentRate;

        [EntityProperty("speedTurbulentCycle", FoxDataType.Float)]
        public float SpeedTurbulentCycle;

        [EntityProperty("rotTurbulentRate", FoxDataType.Float)]
        public float RotTurbulentRate;

        [EntityProperty("rotTurbulentCycle", FoxDataType.Float)]
        public float RotTurbulentCycle;

        [EntityProperty("influenceOfGlobal", FoxDataType.Float)]
        public float InfluenceOfGlobal;
    }
}
 
 