using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxKit.Framework.Tpp.Classes
{
    [TppClass(ClassCategory.TppEffect)]
    public class TppWeatherRainData : Data
    {
        [EntityProperty("rainFilter", FoxDataType.EntityLink)]
        public FoxEntityLink RainFilter;

        [EntityProperty("floorRainSplash", FoxDataType.EntityLink)]
        public FoxEntityLink FloorRainSplash;

        [EntityProperty("vfxFileFallRain", FoxDataType.FilePtr)]
        public string VfxFileFallRain;

        [EntityProperty("vfxFileFallRainSlow", FoxDataType.FilePtr)]
        public string VfxFileFallRainSlow;

        [EntityProperty("vfxFileCameraFog", FoxDataType.FilePtr)]
        public string VfxFileCameraFog;
    }
}