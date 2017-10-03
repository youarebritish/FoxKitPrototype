using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    [TppClass(ClassCategory.Navx)]
    public class NavxHoleSimplificationParameterVolume : TransformData
    {
        [EntityProperty("sceneName", FoxDataType.String)]
        public string SceneName;

        [EntityProperty("worldName", FoxDataType.String)]
        public string WorldName;

        [EntityProperty("convexThreshold", FoxDataType.Float)]
        public float ConvexThreshold;

        [EntityProperty("obbExpandThreshold", FoxDataType.Float)]
        public float ObbExpandThreshold;

        [EntityProperty("obbToAabbThreshold", FoxDataType.Float)]
        public float ObbToAabbThreshold;

        [EntityProperty("smoothingThreshold", FoxDataType.Float)]
        public float SmoothingThreshold;

        [EntityProperty("isNotClosePassage", FoxDataType.Bool)]
        public bool IsNotClosePassage;
    }
}
 
 