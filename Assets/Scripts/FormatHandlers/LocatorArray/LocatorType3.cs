using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace FoxKit.FormatHandlers.LocatorArray
{
    public class LocatorType3 : LocatorBase
    {
        public FoxHash LocatorName;
        public FoxHash DataSet;

        // Still not sure what these values are.
        public FoxHash Unknown30;
        public FoxHash Unknown31;
        public FoxHash Unknown32;
        public FoxHash Unknown33;
        
        public override void Read(BinaryReader reader, Dictionary<uint, string> hashLookupTable, HashIdentifiedDelegate hashIdentifiedCallback)
        {
            HasFooter = true;
            Type = LocatorType.Type3;
            Translation = new Vector4(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
            Rotation = new Quaternion(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());

            Unknown30 = new FoxHash();
            Unknown30.Read(reader, hashLookupTable, hashIdentifiedCallback);

            Unknown31 = new FoxHash();
            Unknown31.Read(reader, hashLookupTable, hashIdentifiedCallback);

            Unknown32 = new FoxHash();
            Unknown32.Read(reader, hashLookupTable, hashIdentifiedCallback);

            Unknown33 = new FoxHash();
            Unknown33.Read(reader, hashLookupTable, hashIdentifiedCallback);
        }

        public override void Write(BinaryWriter writer)
        {
            writer.Write(Translation.x);
            writer.Write(Translation.y);
            writer.Write(Translation.z);
            writer.Write(Translation.w);

            writer.Write(Rotation.x);
            writer.Write(Rotation.y);
            writer.Write(Rotation.z);
            writer.Write(Rotation.w);

            Unknown30.Write(writer);
            Unknown31.Write(writer);
            Unknown32.Write(writer);
            Unknown33.Write(writer);
        }

        public override void ReadFooter(BinaryReader reader, Dictionary<uint, string> hashLookupTable, HashIdentifiedDelegate hashIdentifiedCallback)
        {
            LocatorName = new FoxHash();
            LocatorName.Read(reader, hashLookupTable, hashIdentifiedCallback);

            DataSet = new FoxHash();
            DataSet.Read(reader, hashLookupTable, hashIdentifiedCallback);
        }

        public override void WriteFooter(BinaryWriter writer)
        {
            LocatorName.Write(writer);
            DataSet.Write(writer);
        }
    }
}