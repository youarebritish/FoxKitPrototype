using System;
using FoxKit.FormatHandlers.DataSet;
using FoxKit.FormatHandlers.DataSet.Converters;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Containers
{
    public class FoxStaticArray<T> : FoxListBase<T> where T : IFoxType, new()
    {
        public override IFoxPropertyConverter MakePropertyConverter(Type targetType, IEntityReferenceResolver entityReferenceResolver)
        {
            var value = _values[0];
            if (value is IFoxReferenceType)
            {
                return new ReferenceTypeConverter((value as IFoxReferenceType).ReferencedEntityAddress, entityReferenceResolver);
            }
            if (value is IFoxValueType)
            {
                return new ValueTypeConverter((value as IFoxValueType).Unwrap());
            }
            throw new ArgumentOutOfRangeException("Value was neither IFoxReferenceType nor IFoxType.");
        }
    }
}
