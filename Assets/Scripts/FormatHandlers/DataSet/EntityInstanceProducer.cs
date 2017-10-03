using FoxKit.Framework.Fox;
using System;
using System.Collections.Concurrent;
using UnityEngine;

/// <summary>
/// Creates new Entities on the Unity main thread.
/// </summary>
public class EntityInstanceProducer
{
    private readonly ConcurrentQueue<Type> typesToProduce = new ConcurrentQueue<Type>();
    private readonly ConcurrentDictionary<Type, BlockingCollection<Entity>> producedEntities = new ConcurrentDictionary<Type, BlockingCollection<Entity>>();
    
    public EntityInstanceProducer(int maxInstancesPerUpdate)
    {

    }

    /// <summary>
    /// Not called automatically! The creator is responsible for calling Update().
    /// </summary>
	public void Update ()
    {
        // Produce all requested entity types.
        // TODO: Rate limit
        Type entityTypeToProduce;
        while (typesToProduce.TryDequeue(out entityTypeToProduce))
        {
            ProduceEntity(entityTypeToProduce);
        }
    }

    /// <summary>
    /// Tries to get a produced Entity instance.
    /// </summary>
    /// <param name="entityType">Type of the Entity to get.</param>
    /// <param name="entityInstance">The fetched Entity instance.</param>
    /// <returns>True if successful.</returns>
    public Entity TryGetInstance(Type entityType)
    {
        BlockingCollection<Entity> entityQueue;
        producedEntities.TryGetValue(entityType, out entityQueue);

        return entityQueue.Take();
    }

    /// <summary>
    /// Requests the production of an Entity.
    /// </summary>
    /// <param name="entityType">Type of the Entity to produce.</param>
    public void RequestProduceInstance(Type entityType)
    {
        typesToProduce.Enqueue(entityType);

        BlockingCollection<Entity> entityQueue;
        if (!producedEntities.TryGetValue(entityType, out entityQueue))
        {
            entityQueue = new BlockingCollection<Entity>();
            producedEntities.TryAdd(entityType, entityQueue);
        }
    }

    /// <summary>
    /// Produces an Entity.
    /// </summary>
    /// <param name="entityType">Type of the Entity to produce.</param>
    private void ProduceEntity(Type entityType)
    {
        var go = new GameObject();
        var entity = go.AddComponent(entityType) as Entity;

        BlockingCollection<Entity> entityQueue;
        producedEntities.TryGetValue(entityType, out entityQueue);
        entityQueue.Add(entity);
    }
}
