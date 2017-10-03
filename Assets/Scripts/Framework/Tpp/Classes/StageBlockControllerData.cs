using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class StageBlockControllerData : Data
    {
        [EntityProperty("enable", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean Enable;

        [EntityProperty("stageName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String StageName;

        [EntityProperty("useBaseDirectoryPathAndName", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean UseBaseDirectoryPathAndName;

        [EntityProperty("baseDirectoryPath", FoxDataType.String, FoxContainerType.StaticArray)]
        public String BaseDirectoryPath;

        [EntityProperty("baseName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String BaseName;

        [EntityProperty("smallBlock1BaseDirectoryPath", FoxDataType.String, FoxContainerType.StaticArray)]
        public String SmallBlock1BaseDirectoryPath;

        [EntityProperty("smallBlock1BaseName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String SmallBlock1BaseName;

        [EntityProperty("blockSizeX", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 BlockSizeX;

        [EntityProperty("blockSizeZ", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 BlockSizeZ;

        [EntityProperty("countX", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 CountX;

        [EntityProperty("countZ", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 CountZ;

        [EntityProperty("centerIndexX", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 CenterIndexX;

        [EntityProperty("centerIndexZ", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 CenterIndexZ;

        [EntityProperty("blockSizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 BlockSizeInBytes;

        [EntityProperty("smallBlock1CountX", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 SmallBlock1CountX;

        [EntityProperty("smallBlock1CountZ", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 SmallBlock1CountZ;

        [EntityProperty("smallBlock1BlockSizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 SmallBlock1BlockSizeInBytes;

        [EntityProperty("blockMarginX", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 BlockMarginX;

        [EntityProperty("blockMarginZ", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 BlockMarginZ;

        [EntityProperty("loadingDistanceX", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LoadingDistanceX;

        [EntityProperty("loadingDistanceZ", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LoadingDistanceZ;

        [EntityProperty("commonBlockSizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 CommonBlockSizeInBytes;

        [EntityProperty("largeBlockCount0", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LargeBlockCount0;

        [EntityProperty("largeBlockSizeInBytes0", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LargeBlockSizeInBytes0;

        [EntityProperty("largeBlockCount1", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LargeBlockCount1;

        [EntityProperty("largeBlockSizeInBytes1", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LargeBlockSizeInBytes1;

        [EntityProperty("largeBlockCount2", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LargeBlockCount2;

        [EntityProperty("largeBlockSizeInBytes2", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LargeBlockSizeInBytes2;

        [EntityProperty("largeBlockCount3", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LargeBlockCount3;

        [EntityProperty("largeBlockSizeInBytes3", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LargeBlockSizeInBytes3;

        [EntityProperty("largeBlockLoadingMarginX", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LargeBlockLoadingMarginX;

        [EntityProperty("largeBlockLoadingMarginZ", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 LargeBlockLoadingMarginZ;

        [EntityProperty("stageBlockFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String StageBlockFile;

        [EntityProperty("lod0BaseDirectoryPath", FoxDataType.String, FoxContainerType.StaticArray)]
        public String Lod0BaseDirectoryPath;

        [EntityProperty("lod0BaseName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String Lod0BaseName;

        [EntityProperty("lod0blockSizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Lod0blockSizeInBytes;

        [EntityProperty("lod0blockSizeX", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Lod0blockSizeX;

        [EntityProperty("lod0blockSizeZ", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Lod0blockSizeZ;

        [EntityProperty("lod0BlockCountX", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Lod0BlockCountX;

        [EntityProperty("lod0BlockCountZ", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Lod0BlockCountZ;

        [EntityProperty("lod0LargeBlock0SizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Lod0LargeBlock0SizeInBytes;

        [EntityProperty("lod0LargeBlock0Count", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Lod0LargeBlock0Count;

        [EntityProperty("lod0LargeBlock1SizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Lod0LargeBlock1SizeInBytes;

        [EntityProperty("lod0LargeBlock1Count", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Lod0LargeBlock1Count;

        [EntityProperty("lod0LargeBlock2SizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Lod0LargeBlock2SizeInBytes;

        [EntityProperty("lod0LargeBlock2Count", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Lod0LargeBlock2Count;

        [EntityProperty("lod0LargeBlock3SizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Lod0LargeBlock3SizeInBytes;

        [EntityProperty("lod0LargeBlock3Count", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Lod0LargeBlock3Count;

        [EntityProperty("lod1BaseDirectoryPath", FoxDataType.String, FoxContainerType.StaticArray)]
        public String Lod1BaseDirectoryPath;

        [EntityProperty("lod1BaseName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String Lod1BaseName;

        [EntityProperty("lod1blockSizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Lod1blockSizeInBytes;

        [EntityProperty("lod1blockSizeX", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Lod1blockSizeX;

        [EntityProperty("lod1blockSizeZ", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Lod1blockSizeZ;

        [EntityProperty("lod1BlockCountX", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Lod1BlockCountX;

        [EntityProperty("lod1BlockCountZ", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Lod1BlockCountZ;

        [EntityProperty("lod1LargeBlock0SizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Lod1LargeBlock0SizeInBytes;

        [EntityProperty("lod1LargeBlock0Count", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Lod1LargeBlock0Count;

        [EntityProperty("lod1LargeBlock1SizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Lod1LargeBlock1SizeInBytes;

        [EntityProperty("lod1LargeBlock1Count", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Lod1LargeBlock1Count;

        [EntityProperty("lod1LargeBlock2SizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Lod1LargeBlock2SizeInBytes;

        [EntityProperty("lod1LargeBlock2Count", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Lod1LargeBlock2Count;

        [EntityProperty("lod1LargeBlock3SizeInBytes", FoxDataType.UInt32, FoxContainerType.StaticArray)]
        public UInt32 Lod1LargeBlock3SizeInBytes;

        [EntityProperty("lod1LargeBlock3Count", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte Lod1LargeBlock3Count;
    }
}
