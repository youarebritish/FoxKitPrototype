using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppPlayer2AdditionalMotionBlockData : Data
    {
        [EntityProperty("blockSize", FoxDataType.UInt32)]
        public uint BlockSize;

        [EntityProperty("vramBlockSize", FoxDataType.UInt32)]
        public uint VramBlockSize;

        [EntityProperty("residentVramSyncBufferSize", FoxDataType.UInt32)]
        public uint ResidentVramSyncBufferSize;

        [EntityProperty("baseVramSyncBufferSize", FoxDataType.UInt32)]
        public uint BaseVramSyncBufferSize;

        [EntityProperty("equipVramSyncBufferSize", FoxDataType.UInt32)]
        public uint EquipVramSyncBufferSize;

        [EntityProperty("weaponVramSyncBufferSize", FoxDataType.UInt32)]
        public uint WeaponVramSyncBufferSize;

        [EntityProperty("fpkPath", FoxDataType.Path)]
        public string FpkPath;

        [EntityProperty("vramFpkPath", FoxDataType.Path)]
        public string VramFpkPath;
    }
}
 
 
 