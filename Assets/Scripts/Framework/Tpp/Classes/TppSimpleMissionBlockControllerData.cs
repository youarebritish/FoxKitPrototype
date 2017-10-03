using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    /// <summary>
    /// Loads mission blocks.
    /// </summary>
    public class TppSimpleMissionBlockControllerData : Data
    {
        [EntityProperty("blockSizeInByte", FoxDataType.UInt32)]
        public uint BlockSizeInByte;
    }
}