using FoxKit.Framework.Fox;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;
using System.Collections.Generic;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppOcean : TransformData
    {
        [EntityProperty("enable", FoxDataType.Bool)]
        public bool Enable;

        [EntityProperty("guantanamoOcean", FoxDataType.Bool)]
        public bool GuantanamoOcean;

        [EntityProperty("wireframe", FoxDataType.Bool)]
        public bool Wireframe;

        [EntityProperty("baseHeight", FoxDataType.Float)]
        public float BaseHeight;

        [EntityProperty("gridNumX", FoxDataType.UInt32)]
        public uint GridNumX;

        [EntityProperty("gridNumY", FoxDataType.UInt32)]
        public uint GridNumY;

        [EntityProperty("screenMarginX", FoxDataType.Float)]
        public float ScreenMarginX;

        [EntityProperty("screenMarginY", FoxDataType.Float)]
        public float ScreenMarginY;

        [EntityProperty("waveLengthMin", FoxDataType.Float)]
        public float WaveLengthMin;

        [EntityProperty("waveLengthMax", FoxDataType.Float)]
        public float WaveLengthMax;

        [EntityProperty("waveDispersion", FoxDataType.Float)]
        public float WaveDispersion;

        [EntityProperty("windSpeed", FoxDataType.Float)]
        public float WindSpeed;

        [EntityProperty("waveParamTexture", FoxDataType.Path)]
        public string WaveParamTexture;

        [EntityProperty("whitecapTexture", FoxDataType.Path)]
        public string WhitecapTexture;

        [EntityProperty("horizonDistance", FoxDataType.Float)]
        public float HorizonDistance;

        [EntityProperty("lightCaptureDistance", FoxDataType.Float)]
        public float LightCaptureDistance;

        [EntityProperty("randomSeed", FoxDataType.UInt32)]
        public uint RandomSeed;

        [EntityProperty("collisionDatas", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> CollisionDatas;
    }
}
 