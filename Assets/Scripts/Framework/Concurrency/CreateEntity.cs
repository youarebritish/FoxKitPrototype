using System;
using FoxKit.Framework.Fox;
using UnityEngine;

namespace FoxKit.Framework.Concurrency
{
    public delegate void DeliverNewEntityDelegate(Entity newEntity);

    public class CreateEntity : IUnityThreadCommand
    {
        private readonly Type entityTypeToProduce;
        private readonly DeliverNewEntityDelegate entityCreatedCallback;

        public CreateEntity(Type entityType, DeliverNewEntityDelegate onCreatedDelegate)
        {
            if (entityType == null)
            {
                throw new ArgumentNullException(nameof(entityType));
            }
            if (entityType.IsAssignableFrom(typeof(Entity)))
            {
                throw new ArgumentException("entityType is not an Entity type.");
            }
            if (onCreatedDelegate == null)
            {
                throw new ArgumentNullException(nameof(onCreatedDelegate));
            }

            entityTypeToProduce = entityType;
            entityCreatedCallback = onCreatedDelegate;
        }

        public void Execute()
        {
            var go = new GameObject();
            var entity = go.AddComponent(entityTypeToProduce) as Entity;
            
            entityCreatedCallback.Invoke(entity);
        }
    }
}
