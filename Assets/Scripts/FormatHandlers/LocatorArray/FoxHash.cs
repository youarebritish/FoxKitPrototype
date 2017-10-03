using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Xml;
using FoxKit.FormatHandlers.LocatorArray;

namespace FoxKit.FormatHandlers.LocatorArray
{
    public class FoxHash
    {
        public uint HashValue;
        public string StringLiteral = string.Empty;
        public bool IsStringKnown => StringLiteral != string.Empty;

        public virtual void Read(BinaryReader reader, Dictionary<uint, string> hashLookupTable, HashIdentifiedDelegate hashIdentifiedCallback)
        {
            HashValue = reader.ReadUInt32();

            if (hashLookupTable.ContainsKey(HashValue))
            {
                StringLiteral = hashLookupTable[HashValue];
                hashIdentifiedCallback.Invoke(HashValue, StringLiteral);
            }
        }

        public virtual void Write(BinaryWriter writer)
        {
            writer.Write(HashValue);
        }

        public void ReadXml(XmlReader reader, string label)
        {
            string value = reader[label];

            uint maybeHash;
            if (uint.TryParse(value, out maybeHash))
            {
                HashValue = maybeHash;
            }
            else
            {
                StringLiteral = value;
                HashValue = HashManager.HashString(StringLiteral);
            }
        }

        public void WriteXml(XmlWriter writer, string label)
        {
            if (IsStringKnown)
            {
                writer.WriteAttributeString(label, StringLiteral);
            }
            else
            {
                writer.WriteAttributeString(label, HashValue.ToString(CultureInfo.InvariantCulture));
            }
        }
    }
}