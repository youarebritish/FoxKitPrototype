using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace FoxKit.FormatHandlers.LocatorArray
{
    public class LocatorType0 : LocatorBase
    {
        public override void Read(BinaryReader reader, Dictionary<uint, string> hashLookupTable, HashIdentifiedDelegate hashIdentifiedCallback)
        {
            HasFooter = false;
            Type = LocatorType.Type0;
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
            throw new InvalidOperationException("This locator format does not have a footer.");
        }

        public override void WriteFooter(BinaryWriter writer)
        {
            throw new InvalidOperationException("This locator format does not have a footer.");
        }
    }
}