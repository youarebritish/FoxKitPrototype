using FoxKit.Framework.Tpp.Classes;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A block is a container for level data. A level is an aggregation of multiple blocks, which each contain entity data.
/// There should only be one in a scene.
/// </summary>
public class Block : MonoBehaviour
{
    public List<DataSet> DataSets;
}
