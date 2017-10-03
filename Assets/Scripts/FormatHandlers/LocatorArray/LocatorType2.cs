using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace FoxKit.FormatHandlers.LocatorArray
{
    [System.Serializable]
    public class LocatorType2 : LocatorBase
    {
        public FoxHash LocatorName;
        public FoxHash DataSet;
        
        public override void Read(BinaryReader reader, Dictionary<uint, string> hashLookupTable, HashIdentifiedDelegate hashIdentifiedCallback)
        {
            Type = LocatorType.Type2;
            HasFooter = true;
            Translation = new Vector4(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
            Rotation = new Quaternion(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
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