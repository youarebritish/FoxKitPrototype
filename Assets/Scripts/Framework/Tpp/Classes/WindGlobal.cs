using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    [TppClass(ClassCategory.Wind)]
    public class WindGlobal : Data
    {
        [EntityProperty("parameter", FoxDataType.EntityPtr)]
        public WindParameter Parameter;
    }
}
 
 