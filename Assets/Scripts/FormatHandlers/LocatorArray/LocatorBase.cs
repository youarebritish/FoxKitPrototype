using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

namespace FoxKit.FormatHandlers.LocatorArray
{
    [System.Serializable]
    public class LocatorBase : Object
    {
        public Vector4 Translation;
        public Quaternion Rotation;

        public bool HasFooter { get; protected set; }
        public static LocatorType Type { get; protected set; }

        public virtual void Read(BinaryReader reader, Dictionary<uint, string> hashLookupTable,
            HashIdentifiedDelegate hashIdentifiedCallback)
        {
            
        }

        public virtual void Write(BinaryWriter writer)
        {
            
        }

        public virtual void ReadFooter(BinaryReader reader, Dictionary<uint, string> hashLookupTable,
            HashIdentifiedDelegate hashIdentifiedCallback)
        {
            
        }

        public virtual void WriteFooter(BinaryWriter writer)
        {
            
        }
    }
}