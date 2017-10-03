using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxKit.Framework.Tpp.Classes;
using UnityEngine;

namespace FoxKit.Framework.Concurrency
{
    /// <summary>
    /// Call OnLoaded() for a collection of Entities and parent them to their owning DataSet.
    /// </summary>
    public class InitializeEntities : IUnityThreadCommand
    {
        private readonly DataSet dataSet;
        private readonly IEnumerable<Entity> entitiesToInitialize;

        public InitializeEntities(DataSet dataSet, IEnumerable<Entity> entities)
        {
            this.dataSet = dataSet;
            entitiesToInitialize = entities;
        }

        public void Execute()
        {
            foreach (var entity in entitiesToInitialize)
            {
                if (entity.transform.parent == null)
                {
                    entity.transform.SetParent(dataSet.transform);
                }
                entity.OnLoaded();
            }
            dataSet.SaveToPrefab();
        }
    }
}
