using FoxKit.Framework.Fox;
using FoxKit.Framework.Tpp.Classes;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;
using System.Collections.Generic;

namespace FoxKit.Framework.Tpp.Classes
{
    /// <summary>
    /// Provides a string-keyed lookup table for Entities, allowing them to be referenced ingame.
    /// </summary>
    [TppClass(ClassCategory.Data)]
    public class DataIdentifier : Data
    {
        /// <summary>
        /// Unique identifier used to reference this ingame.
        /// </summary>
        [EntityProperty("identifier", FoxDataType.String)]
        public string Identifier;

        /// <summary>
        /// Maps string keys to entities so they can be referenced ingame.
        /// </summary>
        [EntityProperty("links", FoxDataType.EntityLink, FoxContainerType.StringMap)]
        public Dictionary<string, FoxEntityLink> Links;
    }
}