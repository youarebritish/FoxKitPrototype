using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class DemoData : TransformData
    {
        [EntityProperty("evfFiles", FoxDataType.FilePtr, FoxContainerType.DynamicArray)]
        public List<String> EvfFiles;

        [EntityProperty("onMemory", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean OnMemory;

        [EntityProperty("demoLength", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 DemoLength;

        [EntityProperty("priority", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 Priority;

        [EntityProperty("scriptPath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String ScriptPath;

        [EntityProperty("fmdlFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> FmdlFiles;

        [EntityProperty("helpBoneFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> HelpBoneFiles;

        [EntityProperty("partsDesc", FoxDataType.EntityPtr, FoxContainerType.StringMap)]
        public Dictionary<string, Entity> PartsDesc;

        [EntityProperty("clipDatas", FoxDataType.EntityPtr, FoxContainerType.DynamicArray)]
        public List<Entity> ClipDatas;

        [EntityProperty("loadFiles", FoxDataType.Path, FoxContainerType.DynamicArray)]
        public List<String> LoadFiles;

        [EntityProperty("demoId", FoxDataType.String, FoxContainerType.StaticArray)]
        public String DemoId;

        [EntityProperty("playingRoot", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink PlayingRoot;

        [EntityProperty("streamAnimation", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink StreamAnimation;

        [EntityProperty("demoStreamPath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String DemoStreamPath;

        [EntityProperty("motionPath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String MotionPath;

        [EntityProperty("motionFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String MotionFile;

        [EntityProperty("audioPath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String AudioPath;

        [EntityProperty("subtitleFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String SubtitleFile;

        [EntityProperty("subtitleBinaryFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String SubtitleBinaryFile;

        [EntityProperty("nodeDataFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String NodeDataFile;

        [EntityProperty("stringParams", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> StringParams;

        [EntityProperty("entityParams", FoxDataType.EntityLink, FoxContainerType.StringMap)]
        public Dictionary<string, FoxEntityLink> EntityParams;

        [EntityProperty("fileParams", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, String> FileParams;

        [EntityProperty("controlCharacters", FoxDataType.EntityPtr, FoxContainerType.StringMap)]
        public Dictionary<string, Entity> ControlCharacters;

        [EntityProperty("controlDatas", FoxDataType.EntityLink, FoxContainerType.StringMap)]
        public Dictionary<string, FoxEntityLink> ControlDatas;

        [EntityProperty("controlCollectibles", FoxDataType.String, FoxContainerType.StringMap)]
        public Dictionary<string, String> ControlCollectibles;

        [EntityProperty("parameters", FoxDataType.EntityPtr, FoxContainerType.StringMap)]
        public Dictionary<string, Entity> Parameters;

        [EntityProperty("setupLights", FoxDataType.String, FoxContainerType.StringMap)]
        public Dictionary<string, String> SetupLights;

        [EntityProperty("cameraInterpType", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 CameraInterpType;

        [EntityProperty("cameraInterpFrame", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 CameraInterpFrame;

        [EntityProperty("cameraInterpCurveRate", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CameraInterpCurveRate;

        [EntityProperty("cameraInterpScurveCenter", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CameraInterpScurveCenter;

        [EntityProperty("cameraTranslation", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 CameraTranslation;

        [EntityProperty("cameraRotation", FoxDataType.Quat, FoxContainerType.StaticArray)]
        public Quaternion CameraRotation;

        [EntityProperty("cameraParam", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CameraParam;

        [EntityProperty("cameraDistanceToLookAt", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CameraDistanceToLookAt;

        [EntityProperty("cameraStartTranslation", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 CameraStartTranslation;

        [EntityProperty("cameraStartRotation", FoxDataType.Quat, FoxContainerType.StaticArray)]
        public Quaternion CameraStartRotation;

        [EntityProperty("cameraStartParam", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CameraStartParam;

        [EntityProperty("cameraStartDistanceToLookAt", FoxDataType.Float, FoxContainerType.StaticArray)]
        public Single CameraStartDistanceToLookAt;

        [EntityProperty("eventCacheNum", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 EventCacheNum;

        [EntityProperty("eventInterpCacheNum", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 EventInterpCacheNum;

        [EntityProperty("eventSkipCacheNum", FoxDataType.Int32, FoxContainerType.StaticArray)]
        public Int32 EventSkipCacheNum;

        [EntityProperty("highestTextureStreamModel", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> HighestTextureStreamModel;

        [EntityProperty("highestTexture", FoxDataType.Path, FoxContainerType.DynamicArray)]
        public List<String> HighestTexture;

        [EntityProperty("objectNum", FoxDataType.Int32, FoxContainerType.StringMap)]
        public Dictionary<string, Int32> ObjectNum;

        [EntityProperty("blockPositionSetter", FoxDataType.EntityLink, FoxContainerType.StaticArray)]
        public FoxEntityLink BlockPositionSetter;
    }
}
