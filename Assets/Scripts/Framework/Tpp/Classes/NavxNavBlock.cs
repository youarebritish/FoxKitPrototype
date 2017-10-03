using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    /// <summary>
    /// Defines a navmesh chunk.
    /// </summary>
    [TppClass(ClassCategory.Navx)]
    public class NavxNavBlock : Data
    {
        [EntityProperty("sceneName", FoxDataType.String)]
        public string SceneName;

        [EntityProperty("worldName", FoxDataType.String)]
        public string WorldName;

        [EntityProperty("tileId", FoxDataType.UInt32)]
        public uint TileId;

        [EntityProperty("filePath", FoxDataType.Path)]
        public string FilePath;

        [EntityProperty("filePtr", FoxDataType.FilePtr)]
        public string FilePtr;

        [EntityProperty("remainingFilePtr", FoxDataType.FilePtr)]
        public string RemainingFilePtr;

        [EntityProperty("isSplit", FoxDataType.Bool)]
        public bool IsSplit;

        [EntityProperty("maxFileSizeInKb", FoxDataType.UInt32)]
        public uint MaxFileSizeInKb;

        [EntityProperty("useBlockParameter", FoxDataType.Bool)]
        public bool UseBlockParameter;

        [EntityProperty("verticalThreshold", FoxDataType.Float)]
        public float VerticalThreshold;

        [EntityProperty("simplificationThreshold", FoxDataType.Float)]
        public float SimplificationThreshold;

        [EntityProperty("doesHoleSimplification", FoxDataType.Bool)]
        public bool DoesHoleSimplification;

        [EntityProperty("holeSimplificationConvexThreshold", FoxDataType.Float)]
        public float HoleSimplificationConvexThreshold;

        [EntityProperty("holeSimplificationObbExpandThreshold", FoxDataType.Float)]
        public float HoleSimplificationObbExpandThreshold;

        [EntityProperty("holeSimplificationObbToAabbThreshold", FoxDataType.Float)]
        public float HoleSimplificationObbToAabbThreshold;

        [EntityProperty("holeSimplificationSmoothingThreshold", FoxDataType.Float)]
        public float HoleSimplificationSmoothingThreshold;

        [EntityProperty("isHoleSimplificationDoesNotClosePassage", FoxDataType.Bool)]
        public bool isHoleSimplificationDoesNotClosePassage;

        [EntityProperty("holeSimplificationReduceCount", FoxDataType.UInt32)]
        public uint HoleSimplificationReduceCount;
    }
}
 
 