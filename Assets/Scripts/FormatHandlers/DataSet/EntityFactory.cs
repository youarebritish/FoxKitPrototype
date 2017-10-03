using FoxKit.Framework.Fox;
using FoxTool.Fox;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FoxKit.Framework.Concurrency;
using UnityEngine;

namespace FoxKit.FormatHandlers.DataSet
{
    /// <summary>
    /// Creates concrete FoxKit Entities based on FoxFile entries.
    /// </summary>
    public static class EntityFactory
    {
        public static Entity MakeEntity(FoxEntity foxData, Dictionary<string, Type> entityTypes, ConcurrentDictionary<string, FoxEntity> unimplementedTypeTable, IUnityThreadCommandDispatcher unityThreadDispatcher, IEntityReferenceResolver entityReferenceResolver)
        {
            // Get Entity type.
            Type entityType;
            if (!entityTypes.TryGetValue(foxData.ClassName, out entityType) && !unimplementedTypeTable.ContainsKey(foxData.ClassName))
            {
                Debug.LogWarning("Class '" + foxData.ClassName + "' not found in entityTypes.");
                unimplementedTypeTable.TryAdd(foxData.ClassName, foxData);
                return null;
            }

            // Get new Entity instance.
            // We can't make new GameObjects outside the main thread, so dispatch a request for one to the Unity thread.
            Entity entityInstance = null;
            var waitEvent = unityThreadDispatcher.DispatchCommand(new CreateEntity(entityType,
                newEntity => entityInstance = newEntity));

            // Wait for our command to be executed by the Unity thread.
            waitEvent.WaitOne();
            entityReferenceResolver.RegisterReference(foxData.Address, entityInstance);
            
            // Load properties.
            ImportEntityProperties(entityInstance, foxData, entityReferenceResolver);
            return entityInstance;
        }

        private static void ImportEntityProperties(Entity entityInstance, FoxEntity foxEntityData, IEntityReferenceResolver entityReferenceResolver)
        {
            foreach (var foxProperty in foxEntityData.StaticProperties)
                //.Concat(foxEntityData.DynamicProperties)) -- Dynamic properties don't work yet.
            {
                try
                {
                    ImportEntityProperty(entityInstance, foxProperty, entityReferenceResolver);
                }
                catch (Exception e)
                {
                    Debug.LogError(e);
                }
            }
        }

        private static void ImportEntityProperty(Entity entityInstance, FoxProperty foxProperty, IEntityReferenceResolver entityReferenceResolver)
        {
            var entityPropertyAndFieldInfo =
                FindMatchingEntityPropertyAndFieldInfo(entityInstance.GetType(), foxProperty.Name);
            
            var converter = foxProperty.Container.MakePropertyConverter(entityPropertyAndFieldInfo.Item2.FieldType, entityReferenceResolver);
            converter.ConvertFromFox(entityInstance, entityPropertyAndFieldInfo.Item2);
        }

        /// <summary>
        /// For an Entity type, find the EntityProperty and corresponding FieldInfo with a given name.
        /// </summary>
        /// <param name="entityType">Type of the Entity whose fields to search.</param>
        /// <param name="fieldName">Name of the EntityProperty attribute to find.</param>
        /// <returns>The EntityProperty attribute and corresponding FieldInfo matching the desired field name.</returns>
        private static Tuple<EntityProperty, FieldInfo> FindMatchingEntityPropertyAndFieldInfo(Type entityType,
            string fieldName)
        {
            foreach (var fieldInfo in entityType.GetFields())
            {
                var entityPropertyAttribute = GetEntityPropertyAttribute(fieldInfo);
                if (entityPropertyAttribute.Name == fieldName)
                {
                    return Tuple.Create(entityPropertyAttribute, fieldInfo);
                }
            }
            throw new EntityPropertyAttributeNotFoundException(
                $"No EntityProperty attribute with the name '{fieldName}' found in object type '{entityType.Name}'");
        }

        /// <summary>
        /// Gets the EntityProperty attribute on the given field.
        /// </summary>
        /// <param name="fieldInfo">Entity field to get the EntityProperty attribute from. There should be exactly one EntityProperty attribute on it.</param>
        /// <returns>The EntityProperty attribute, or null if none found.</returns>
        private static EntityProperty GetEntityPropertyAttribute(FieldInfo fieldInfo)
        {
            var result = fieldInfo.GetCustomAttributes(typeof(EntityProperty), true);

            if (result.Length != 1)
            {
                throw new EntityPropertyAttributeNotFoundException(
                    $"EntityProperty attribute not found on field '{fieldInfo.Name}' of object type '{fieldInfo.DeclaringType.Name}'");
            }
            return result[0] as EntityProperty;
        }
    }
}
