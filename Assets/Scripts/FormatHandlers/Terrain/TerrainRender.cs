using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainRender : MonoBehaviour
{
    private TerrainData terrainData;

    public TerrainData TerrainData
    {
        get
        {
            return terrainData;
        }

        set
        {
            Initialize(value);
        }
    }

    void Initialize(TerrainData terrainData)
    {
        this.terrainData = terrainData;
    }
}
