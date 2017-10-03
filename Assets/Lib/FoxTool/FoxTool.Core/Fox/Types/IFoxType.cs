using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using FoxKit.FormatHandlers.DataSet;

namespace FoxTool.Fox.Types
{
    public interface IFoxType : IXmlSerializable
    {
        void Read(Stream input);
        void Write(Stream output);
        int Size();
        void ResolveStringLiterals(FoxLookupTable lookupTable);
        void CalculateHashes();
        void CollectStringLookupLiterals(List<FoxStringLookupLiteral> literals);
    }

    public interface IFoxValueType : IFoxType
    {
        /// <summary>
        /// Convert to a standard C# type.
        /// </summary>
        object Unwrap();
    }

    public interface IFoxReferenceType : IFoxType
    {
        ulong ReferencedEntityAddress { get; }
    }
}
