using System.Diagnostics;
using System.Reflection;
using FoxKit.Framework.Fox;
using FoxKit.Framework.Tpp.Classes;

namespace FoxKit.FormatHandlers.DataSet.Converters
{
    public class ReferenceTypeConverter : IFoxPropertyConverter
    {
        private Entity convertedValue;
        private Entity requestingInstance;
        private FieldInfo requestingField;

        public ReferenceTypeConverter(ulong referencedEntityAddress, IEntityReferenceResolver entityReferenceResolver)
        {
            entityReferenceResolver.RequestReference(AssignReference, referencedEntityAddress);
        }

        public void ConvertFromFox(Entity targetInstance, FieldInfo targetField)
        {
            // If the reference has already been resolved, assign it to the target field
            if (convertedValue != null)
            {
                targetField.SetValue(targetInstance, convertedValue);
            }
            // If the reference has not yet been resolved, hold onto the target field and instance so we can assign the reference when it's found.
            else
            {
                requestingInstance = targetInstance;
                requestingField = targetField;
            }
        }

        private void AssignReference(Entity entityReference)
        {
            if (requestingInstance != null && requestingField != null)
            {
                requestingField.SetValue(requestingInstance, entityReference);
            }
            else
            {
                convertedValue = entityReference;
            }
        }
    }
}