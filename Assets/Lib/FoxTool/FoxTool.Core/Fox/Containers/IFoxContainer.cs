using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using FoxKit.FormatHandlers.DataSet;

namespace FoxTool.Fox.Containers
{
    public interface IFoxContainer : IXmlSerializable, IEnumerable
    {
        void Read(Stream input, short valueCount);
        void Write(Stream output);
        void ResolveStringLiterals(FoxLookupTable lookupTable);
        int Count();
        void CalculateHashes();
        void CollectStringLookupLiterals(List<FoxStringLookupLiteral> literals);
        IFoxPropertyConverter MakePropertyConverter(Type targetType, IEntityReferenceResolver entityReferenceResolver);
    }
}
