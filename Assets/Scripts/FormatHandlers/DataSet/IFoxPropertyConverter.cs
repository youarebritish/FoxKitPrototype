using System.Reflection;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Containers;

namespace FoxKit.FormatHandlers.DataSet
{
    /// <summary>
    /// Interface for converting a property to and from Fox data types.
    /// </summary>
    public interface IFoxPropertyConverter
    {
        /// <summary>
        /// Converts a Fox property container to the target type and assigns it to its corresponding field...
        /// </summary>
        /// <param name="targetInstance">The Entity to assign the converted value to.</param>
        /// <param name="targetField">The field to assign the converted value to.</param>
        void ConvertFromFox(Entity targetInstance, FieldInfo targetField);
    }
}