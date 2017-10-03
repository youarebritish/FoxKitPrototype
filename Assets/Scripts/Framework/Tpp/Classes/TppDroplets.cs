using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppDroplets : Data
    {
        [EntityProperty("timeBetweenNewDroplets", FoxDataType.Float)]
        public float TimeBetweenNewDroplets;

        [EntityProperty("timeBetweenNewBigDroplets", FoxDataType.Float)]
        public float TimeBetweenNewBigDroplets;

        [EntityProperty("timeBetweenTwoNewBigDropletsAtTheSameTime", FoxDataType.Float)]
        public float TimeBetweenTwoNewBigDropletsAtTheSameTime;

        [EntityProperty("dropletsSize", FoxDataType.Float)]
        public float DropletsSize;

        [EntityProperty("dropletsVelocity", FoxDataType.Float)]
        public float DropletsVelocity;

        [EntityProperty("dropletsTransparency", FoxDataType.Float)]
        public float DropletsTransparency;

        [EntityProperty("minimumMassToStartMoving", FoxDataType.Float)]
        public float MinimumMassToStartMoving;

        [EntityProperty("minimumVelocityToAdvance", FoxDataType.Float)]
        public float MinimumVelocityToAdvance;

        [EntityProperty("remainingMassPropotionWhenDropletsMove", FoxDataType.Float)]
        public float RemainingMassPropotionWhenDropletsMove;

        [EntityProperty("residualWaterMinimumRenderingRadius", FoxDataType.Float)]
        public float ResidualWaterMinimumRenderingRadius;
        
        [EntityProperty("residualWaterMaximumRenderingRadius", FoxDataType.Float)]
        public float ResidualWaterMaximumRenderingRadius;

        [EntityProperty("residualWaterMaximumIntensity", FoxDataType.Float)]
        public float ResidualWaterMaximumIntensity;
    }
}
 