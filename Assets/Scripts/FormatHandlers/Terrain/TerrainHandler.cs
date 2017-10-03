using System;
using GzsTool.Core.Common;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using FoxKit.FormatHandlers;
using GzsTool.Core.Common.Interfaces;
using UnityEditor;

namespace FoxKit.FormatHandlers.Terrain
{
    /// <summary>
    /// Handles tre2 (low res terrain) files.
    /// </summary>
    public class TerrainHandler : IFoxAssetHandler
    {
        private static readonly List<string> DecompilableExtensions = new List<string>
        {
            "tre2"
        };

        public List<string> Extensions => DecompilableExtensions;

        public void Export(object asset, string path)
        {
            throw new NotImplementedException();
        }

        public void Import(Stream input, string path)
        {
            var file = new TerrainRender();

            using (var reader = new BinaryReader(input))
            {
                reader.ReadBytes(236);
                float maxHeight = reader.ReadSingle();
                reader.ReadBytes(12);
                float minHeight = reader.ReadSingle();

                reader.ReadBytes(80);
                var miniHeightMapBytes = reader.ReadUInt32();
                reader.ReadBytes(364);

                Debug.Log(maxHeight);
                Debug.Log(minHeight);

                // Just grab the super low LOD for now
                // It's at position 4 in the heightMap section I think
                reader.ReadBytes((int) (miniHeightMapBytes * 4));

                var miniHeightmap = new float[128, 128];

                for (var x = 0; x < 128; x++)
                {
                    for (var y = 0; y < 128; y++)
                    {
                        miniHeightmap[y, x] = (reader.ReadSingle() - minHeight) / maxHeight;
                    }
                }

                file.TerrainData = CreateTerrainData(128, new Vector3(8192, maxHeight - minHeight, 8192),
                    miniHeightmap);
            }

            AssetDatabase.CreateAsset(file.TerrainData, "Assets/New Terrain.asset");
        }

        static TerrainData CreateTerrainData(int resolution, Vector3 size, float[,] heightMap)
        {
            var terrainData = new TerrainData();
            terrainData.heightmapResolution = resolution;
            terrainData.size = size;
            terrainData.SetHeights(0, 0, heightMap);

            //terrainData.baseMapResolution = 1024; // ???
            //AssetDatabase.CreateAsset(terrainData, "Assets/New Terrain.asset");
            return terrainData;
        }
    }
}