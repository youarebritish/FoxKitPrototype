using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppWeatherParasiteUnitParam : Data
    {
        [EntityProperty("vfxCameraFront", FoxDataType.FilePtr)]
        public string VfxCameraFront;

        [EntityProperty("enableDebugMistRate", FoxDataType.Bool)]
        public bool EnableDebugMistRate;

        [EntityProperty("debugMistRate", FoxDataType.Float)]
        public float DebugMistRate;
    }
}