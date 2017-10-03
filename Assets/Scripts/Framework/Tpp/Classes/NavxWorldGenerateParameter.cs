using FoxKit.Framework.Fox;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types;
using System.Collections.Generic;

namespace FoxKit.Framework.Tpp.Classes
{
    /// <summary>
    /// Defines navmesh generation parameters.
    /// </summary>
    [TppClass(ClassCategory.Navx)]
    public class NavxWorldGenerateParameter : TransformData
    {
        [EntityProperty("resolution", FoxDataType.Float)]
        public float Resolution;

        [EntityProperty("verticalThreshold", FoxDataType.Float)]
        public float VerticalThreshold;

        [EntityProperty("doesDivideIslandWithSector", FoxDataType.Bool)]
        public bool DoesDivideIslandWithSector;

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
        public bool IsHoleSimplificationDoesNotClosePassage;

        [EntityProperty("holeSimplificationReduceCount", FoxDataType.UInt32)]
        public uint HoleSimplificationReduceCount;

        [EntityProperty("doesAdjustSearchSpaceToNavmesh", FoxDataType.Bool)]
        public bool DoesAdjustSearchSpaceToNavmesh;

        [EntityProperty("doesGenerateFillNavVolumeInRadius", FoxDataType.Bool)]
        public bool DoesGenerateFillNavVolumeInRadius;        

        [EntityProperty("roughGraphFilePath", FoxDataType.Path)]
        public string RoughGraphFilePath;

        [EntityProperty("roughGraphFilePtr", FoxDataType.FilePtr)]
        public string RoughGraphFilePtr;

        [EntityProperty("worldName", FoxDataType.String)]
        public string WorldName;

        [EntityProperty("maxFileSizeInKb", FoxDataType.UInt32)]
        public uint MaxFileSizeInKb;

        [EntityProperty("parameters", FoxDataType.EntityPtr, FoxContainerType.DynamicArray)]
        public List<NavxNavigableParameter> Parameters;

        [EntityProperty("sectorSizeHorizontal", FoxDataType.UInt32)]
        public uint SectorSizeHorizontal;

        [EntityProperty("tileSizeHorizontal", FoxDataType.UInt32)]
        public uint TileSizeHorizontal;

        [EntityProperty("searchSpaceBucketSizeHorizontal", FoxDataType.UInt32)]
        public uint SearchSpaceBucketSizeHorizontal;

        [EntityProperty("collisionAttributes", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<string> CollisionAttributes;

        [EntityProperty("loadFox2FileListScriptPath", FoxDataType.Path)]
        public string LoadFox2FileListScriptPath;
    }
}
 
 