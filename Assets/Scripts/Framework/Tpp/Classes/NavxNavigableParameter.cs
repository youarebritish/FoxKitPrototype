using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    /// <summary>
    /// Defines navigability parameters for a certain kind of entity (e.g., Human, Sahelanthropus).
    /// </summary>
    [TppClass(ClassCategory.Navx)]
    public class NavxNavigableParameter : DataElement<NavxWorldGenerateParameter>
    {
        [EntityProperty("name", FoxDataType.String)]
        public string Name;

        [EntityProperty("isDefault", FoxDataType.Bool)]
        public bool IsDefault;

        [EntityProperty("radius", FoxDataType.Float)]
        public float Radius;

        [EntityProperty("simplificationThreshold", FoxDataType.Float)]
        public float SimplificationThreshold;

        [EntityProperty("height", FoxDataType.Float)]
        public float Height;

        [EntityProperty("maxClimbableAngle", FoxDataType.Float)]
        public float MaxClimbableAngle;

        [EntityProperty("maxStepSize", FoxDataType.Float)]
        public float MaxStepSize;

        [EntityProperty("minArea", FoxDataType.Float)]
        public float MinArea;
    }
}
 
 