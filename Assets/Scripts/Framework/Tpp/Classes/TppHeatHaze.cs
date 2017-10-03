using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppHeatHaze : Data
    {
        [EntityProperty("distortionIntensityFullResolution", FoxDataType.Float)]
        public float DistortionIntensityFullResolution;

        [EntityProperty("distortionVelocityFullResolution", FoxDataType.Float)]
        public float DistortionVelocityFullResolution;

        [EntityProperty("distortionTextureRepetitionFullResolution", FoxDataType.Float)]
        public float DistortionTextureRepetitionFullResolution;

        [EntityProperty("hazeMirageIntensityFullResolution", FoxDataType.Float)]
        public float HazeMirageIntensityFullResolution;

        [EntityProperty("hazeStartDistanceFullResolution", FoxDataType.Float)]
        public float HazeStartDistanceFullResolution;

        [EntityProperty("hazeEndDistanceFullResolution", FoxDataType.Float)]
        public float HazeEndDistanceFullResolution;

        [EntityProperty("hazeRangeAttenuationFullResolution", FoxDataType.Float)]
        public float HazeRangeAttenuationFullResolution;

        [EntityProperty("hazeSecondLayerIntensityDifference", FoxDataType.Float)]
        public float HazeSecondLayerIntensityDifference;

        [EntityProperty("hazeSecondLayerStartDistance", FoxDataType.Float)]
        public float HazeSecondLayerStartDistance;

        [EntityProperty("hazeSecondLayerBlurRadius", FoxDataType.Float)]
        public float HazeSecondLayerBlurRadius;

        [EntityProperty("hazeDistortionIntensityAddedOnBinoculars", FoxDataType.Float)]
        public float HazeDistortionIntensityAddedOnBinoculars;

        [EntityProperty("mirageColorSaturation", FoxDataType.Float)]
        public float MirageColorSaturation;

        [EntityProperty("mirageSpreadingPower", FoxDataType.Float)]
        public float MirageSpreadingPower;

        [EntityProperty("mirageRayLength", FoxDataType.Float)]
        public float MirageRayLength;

        [EntityProperty("mirageHitRange", FoxDataType.Float)]
        public float MirageHitRange;

        [EntityProperty("mirageStartDistance", FoxDataType.Float)]
        public float MirageStartDistance;

        [EntityProperty("mirageRangeAttenuation", FoxDataType.Float)]
        public float MirageRangeAttenuation;

        [EntityProperty("distortionIntensityHalfResolution", FoxDataType.Float)]
        public float DistortionIntensityHalfResolution;

        [EntityProperty("distortionVelocityHalfResolution", FoxDataType.Float)]
        public float DistortionVelocityHalfResolution;

        [EntityProperty("distortionTextureRepetitionHalfResolution", FoxDataType.Float)]
        public float DistortionTextureRepetitionHalfResolution;

        [EntityProperty("hazeIntensityHalfResolution", FoxDataType.Float)]
        public float HazeIntensityHalfResolution;

        [EntityProperty("hazeStartDistanceHalfResolution", FoxDataType.Float)]
        public float HazeStartDistanceHalfResolution;

        [EntityProperty("hazeEndDistanceHalfResolution", FoxDataType.Float)]
        public float HazeEndDistanceHalfResolution;

        [EntityProperty("hazeRangeAttenuationHalfResolution", FoxDataType.Float)]
        public float HazeRangeAttenuationHalfResolution;
    }
}
 