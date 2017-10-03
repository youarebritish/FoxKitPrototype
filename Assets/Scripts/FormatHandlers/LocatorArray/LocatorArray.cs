using System;
using System.IO;
using UnityEngine;

namespace FoxKit.FormatHandlers.LocatorArray
{
    /// <summary>
    /// Found this enum in a string dump. Related?
    /// LOCATOR_TYPE_MODEL
    /// LOCATOR_TYPE_NONE
    /// LOCATOR_TYPE_NULL
    /// LOCATOR_TYPE_PARTS
    /// </summary>
    public enum LocatorType
    {
        Type0 = 0,
        Type2 = 2,
        Type3 = 3
    }
    
    [Serializable]
    public class LocatorArray : ScriptableObject
    {
        public LocatorType LocatorType;
        public Vector4[] LocatorTranslations;
        public Quaternion[] LocatorRotations;
        public string[] LocatorNames;
        public string[] LocatorDataSets;
        public string[] LocatorUnknown30s;
        public string[] LocatorUnknown31s;
        public string[] LocatorUnknown32s;
        public string[] LocatorUnknown33s;

        public void Read(LocatorType type, uint locatorCount, BinaryReader reader, HashManager hashManager)
        {
            LocatorType = type;
            reader.ReadDouble();
            
            var hasFooter = GetHasFooter(LocatorType);
            var hasUnknownMetadata = GetHasUnknownMetadata(LocatorType);

            // Initialize fields.
            LocatorTranslations = new Vector4[locatorCount];
            LocatorRotations = new Quaternion[locatorCount];

            if (hasFooter)
            {
                LocatorNames = new string[locatorCount];
                LocatorDataSets = new string[locatorCount];
            }

            if (hasUnknownMetadata)
            {
                LocatorUnknown30s = new string[locatorCount];
                LocatorUnknown31s = new string[locatorCount];
                LocatorUnknown32s = new string[locatorCount];
                LocatorUnknown33s = new string[locatorCount];
            }

            // Read locators.
            for (var i = 0; i < locatorCount; i++)
            {
                LocatorTranslations[i] = new Vector4(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
                LocatorRotations[i] = new Quaternion(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());

                if (!hasUnknownMetadata) continue;

                // TODO Resolve hashes.
                LocatorUnknown30s[i] = reader.ReadUInt32().ToString(); 
                LocatorUnknown31s[i] = reader.ReadUInt32().ToString();
                LocatorUnknown32s[i] = reader.ReadUInt32().ToString();
                LocatorUnknown33s[i] = reader.ReadUInt32().ToString();
            }

            // Read footer.
            if (!hasFooter) return;

            for (var i = 0; i < locatorCount; i++)
            {
                // TODO Resolve hashes.
                LocatorNames[i] = reader.ReadUInt32().ToString();
                LocatorDataSets[i] = reader.ReadUInt32().ToString();
            }
        }

        public void Write(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }

        public void Visualize()
        {
            foreach (var location in LocatorTranslations)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(location, 3.0f);
            }
        }

        private static bool GetHasFooter(LocatorType type)
        {
            return type != LocatorType.Type0;
        }

        private static bool GetHasUnknownMetadata(LocatorType type)
        {
            return type == LocatorType.Type3;
        }
    }
}