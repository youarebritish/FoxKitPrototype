using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using FoxKit.FormatHandlers.DataSet;
using FoxKit.FormatHandlers.DataSet.Converters;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxTool.Fox.Containers
{
    public class FoxListBase<T> : IFoxContainer, IEnumerable<T> where T : IFoxType, new()
    {
        protected readonly List<T> _values;

        public FoxListBase()
        {
            _values = new List<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) _values).GetEnumerator();
        }

        public void Read(Stream input, short valueCount)
        {
            for (int i = 0; i < valueCount; i++)
            {
                T value = new T();
                value.Read(input);
                _values.Add(value);
            }
        }

        public void Write(Stream output)
        {
            foreach (var value in _values)
            {
                value.Write(output);
            }
        }

        public void ResolveStringLiterals(FoxLookupTable lookupTable)
        {
            foreach (var value in _values)
            {
                value.ResolveStringLiterals(lookupTable);
            }
        }

        public int Count()
        {
            return _values.Count;
        }

        public void CalculateHashes()
        {
            foreach (var value in _values)
            {
                value.CalculateHashes();
            }
        }

        public void CollectStringLookupLiterals(List<FoxStringLookupLiteral> literals)
        {
            foreach (var value in _values)
            {
                value.CollectStringLookupLiterals(literals);
            }
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            while (reader.LocalName == "value")
            {
                T value = new T();
                value.ReadXml(reader);
                _values.Add(value);
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            if (_values.Any())
            {
                writer.WriteAttributeString("arraySize", _values.Count().ToString());
                foreach (var value in _values)
                {
                    writer.WriteStartElement("value");
                    value.WriteXml(writer);
                    writer.WriteEndElement();
                }
            }
        }

        public virtual IFoxPropertyConverter MakePropertyConverter(Type targetType, IEntityReferenceResolver entityReferenceResolver)
        {
            var convertedList = Activator.CreateInstance(targetType) as IList;

            for (var i = 0; i < _values.Count; i++)
            {
                var value = _values[i];
                if (value is IFoxReferenceType)
                {
                    // Add null as a placeholder.
                    // Replace it with the Entity reference once resolved.
                    convertedList.Add(null);
                    var iCopy = i;
                    AssignReferenceDelegate referenceAssignmentDelegate = delegate(Entity reference)
                        {
                            convertedList[iCopy] = reference;
                        };
                    entityReferenceResolver.RequestReference(referenceAssignmentDelegate, (value as IFoxReferenceType).ReferencedEntityAddress);
                }
                else if (value is IFoxValueType)
                {
                    convertedList.Add((value as IFoxValueType).Unwrap());
                }
            }
            return new ValueTypeConverter(convertedList);
        }
    }
}
