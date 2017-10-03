using System.Collections;
using System.Collections.Generic;
using System;

namespace FoxKit.FormatHandlers.DataSet
{
    /// <summary>
    /// Thrown when attempting to access an EntityProperty that on a field that doesn't have one.
    /// </summary>
    public class EntityPropertyAttributeNotFoundException : Exception
    {
        public EntityPropertyAttributeNotFoundException()
        {
        }

        public EntityPropertyAttributeNotFoundException(string message)
            : base(message)
        {
        }

        public EntityPropertyAttributeNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}