using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppRainFilter : Data
    {
        [EntityProperty("enable", FoxDataType.Bool)]
        public bool Enable;

        [EntityProperty("startFadeInDistance", FoxDataType.Float)]
        public float StartFadeInDistance;

        [EntityProperty("endFadeInDistance", FoxDataType.Float)]
        public float EndFadeInDistance;

        [EntityProperty("startFadeOutDistance", FoxDataType.Float)]
        public float StartFadeOutDistance;

        [EntityProperty("endFadeOutDistance", FoxDataType.Float)]
        public float EndFadeOutDistance;

        [EntityProperty("albedoExtinctionRatio", FoxDataType.Float)]
        public float AlbedoExtinctionRatio;

        [EntityProperty("roughnessExtinctionCoefficient", FoxDataType.Float)]
        public float RoughnessExtinctionCoefficient;

        [EntityProperty("roughnessEffectiveThreshold", FoxDataType.Float)]
        public float RoughnessEffectiveThreshold;

        [EntityProperty("LABDiffuseScale", FoxDataType.Float)]
        public float LABDiffuseScale;

        [EntityProperty("LABDiffuseAdd", FoxDataType.Float)]
        public float LABDiffuseAdd;

        [EntityProperty("floorTexScale", FoxDataType.Float)]
        public float FloorTexScale;

        [EntityProperty("wallTexScale0", FoxDataType.Float)]
        public float WallTexScale0;

        [EntityProperty("wallTexScale1", FoxDataType.Float)]
        public float WallTexScale1;

        [EntityProperty("wallTexSpeed", FoxDataType.Vector4)]
        public Vector4 WallTexSpeed;

        [EntityProperty("maskTexScale0", FoxDataType.Float)]
        public float MaskTexScale0;

        [EntityProperty("maskTexScale1", FoxDataType.Float)]
        public float MaskTexScale1;

        [EntityProperty("maskTexSpeed", FoxDataType.Vector4)]
        public Vector4 MaskTexSpeed;

        [EntityProperty("rainColor", FoxDataType.Color)]
        public Color RainColor;

        [EntityProperty("windScale", FoxDataType.Float)]
        public float WindScale;

        [EntityProperty("wallAlphaRate", FoxDataType.Float)]
        public float WallAlphaRate;

        [EntityProperty("normalWallTexPath", FoxDataType.Path)]
        public string NormalWallTexPath;

        [EntityProperty("normalFloorTexPath", FoxDataType.Path)]
        public string NormalFloorTexPath;

        [EntityProperty("reflectionCubeMapTexPath", FoxDataType.Path)]
        public string ReflectionCubeMapTexPath;

        [EntityProperty("maskTexPath", FoxDataType.Path)]
        public string MaskTexPath;
    }
}