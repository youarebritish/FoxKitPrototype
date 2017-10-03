using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    [TppClass(ClassCategory.Config)]
    public class GrReflectionSetting : Data
    {
        [EntityProperty("reflectionTexturePath", FoxDataType.Path)]
        public string ReflectionTexturePath;
    }
}
 
 