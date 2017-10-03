using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    public abstract class SoundAreaBase : Data
    {
        [EntityProperty("parameter", FoxDataType.EntityPtr)]
        public SoundAreaParameter Parameter;
    }
}