using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppFourierOcean : Data
    {
        /// <remarks>
        /// The property is mispelled as "displacementStrenght" in game files. Don't fix this "typo."
        /// </remarks>
        [EntityProperty("displacementStrenght", FoxDataType.Float)]
        public float DisplacementStrength;

        [EntityProperty("velocity", FoxDataType.Float)]
        public float Velocity;

        [EntityProperty("windDirectionX", FoxDataType.Float)]
        public float WindDirectionX;

        [EntityProperty("windDirectionZ", FoxDataType.Float)]
        public float WindDirectionZ;

        [EntityProperty("waveAmplitude", FoxDataType.Float)]
        public float WaveAmplitude;

        [EntityProperty("windSpeed", FoxDataType.Float)]
        public float WindSpeed;

        [EntityProperty("windDependency", FoxDataType.Float)]
        public float WindDependency;

        [EntityProperty("baseHeight", FoxDataType.Float)]
        public float BaseHeight;

        [EntityProperty("choppyScale", FoxDataType.Float)]
        public float ChoppyScale;

        [EntityProperty("projectionScale", FoxDataType.Float)]
        public float ProjectionScale;

        [EntityProperty("blendStart", FoxDataType.Float)]
        public float BlendStart;

        [EntityProperty("blendEnd", FoxDataType.Float)]
        public float BlendEnd;

        [EntityProperty("farProjectionScale", FoxDataType.Float)]
        public float FarProjectionScale;

        [EntityProperty("farProjectionAmplitude", FoxDataType.Float)]
        public float FarProjectionAmplitude;

        /// <remarks>
        /// Yes, this property is misspelled, too. Don't fix it.
        /// </remarks>
        [EntityProperty("farProjectionNormalStrenght", FoxDataType.Float)]
        public float FarProjectionNormalStrength;

        [EntityProperty("reflectionPower", FoxDataType.Float)]
        public float ReflectionPower;

        [EntityProperty("specularIntensity", FoxDataType.Float)]
        public float SpecularIntensity;

        [EntityProperty("foamAmount", FoxDataType.Float)]
        public float FoamAmount;
    }
}
 
 