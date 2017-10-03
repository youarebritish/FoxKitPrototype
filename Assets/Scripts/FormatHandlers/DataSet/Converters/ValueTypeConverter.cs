using System.Reflection;
using FoxKit.Framework.Fox;

namespace FoxKit.FormatHandlers.DataSet.Converters
{
    public class ValueTypeConverter : IFoxPropertyConverter
    {
        private readonly object convertedValue;

        public ValueTypeConverter(object convertedValue)
        {
            this.convertedValue = convertedValue;
        }

        public void ConvertFromFox(Entity targetInstance, FieldInfo targetField)
        {
            targetField.SetValue(targetInstance, convertedValue);
        }
    }
}