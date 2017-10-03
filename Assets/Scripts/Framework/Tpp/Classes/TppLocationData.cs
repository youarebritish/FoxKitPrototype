using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppLocationData : Data
    {
        [EntityProperty("locationId", FoxDataType.UInt16)]
        public ushort LocationId;

        [EntityProperty("scriptPath", FoxDataType.Path)]
        public string ScriptPath;

        [EntityProperty("weatherParametersFile", FoxDataType.FilePtr)]
        public string WeatherParametersFile;
    }
}
 
 