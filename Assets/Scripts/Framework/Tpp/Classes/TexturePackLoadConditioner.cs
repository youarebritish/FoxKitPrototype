using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    [TppClass(ClassCategory.Texture)]
    public class TexturePackLoadConditioner : Data
    {
        [EntityProperty("texturePackPath", FoxDataType.Path)]
        public string TexturePackPath;
    }
}
 