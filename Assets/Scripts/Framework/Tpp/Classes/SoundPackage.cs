using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    [TppClass(ClassCategory.Sound)]
    public class SoundPackage : Data
    {
        [EntityProperty("soundDataFile", FoxDataType.FilePtr)]
        public string SoundDataFile;

        [EntityProperty("syncLoad", FoxDataType.Bool)]
        public bool SyncLoad;
    }
}
 