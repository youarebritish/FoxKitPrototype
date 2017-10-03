using FoxTool.Fox.Containers;
using FoxTool.Fox.Types;
using System;

namespace FoxKit.Framework.Fox
{
    [AttributeUsage(AttributeTargets.Field)]
    public class EntityProperty : Attribute
    {
        /// <summary>
        /// The name of the property as it appears in fox2 files.
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// The Fox data type of the property.
        /// </summary>
        /// <remarks>
        /// See DataSetHandler.ConvertFoxValue() for Fox<->FoxKit data type mappings.
        /// </remarks>
        public readonly FoxDataType Type;

        /// <summary>
        /// Type of the property container. Only relevant if IsCollection.
        /// </summary>
        public readonly FoxContainerType Container;

        /// <summary>
        /// Is it a dynamic property? If not, it's static.
        /// </summary>
        public readonly bool IsDynamic;
        
        public EntityProperty(string name, FoxDataType type, FoxContainerType container = FoxContainerType.StaticArray, bool isDynamic = false)
        {
            Name = name;
            Type = type;
            Container = container;
            IsDynamic = isDynamic;
        }
    }
}