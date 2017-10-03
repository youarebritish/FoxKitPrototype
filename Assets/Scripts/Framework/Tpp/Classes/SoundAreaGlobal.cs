using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    [TppClass(ClassCategory.Sound)]
    public class SoundAreaGlobal : SoundAreaBase
    {
        [EntityProperty("volumeRtpc", FoxDataType.String)]
        public string VolumeRtpc;
    }
}
 