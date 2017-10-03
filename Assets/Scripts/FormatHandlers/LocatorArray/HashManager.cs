using System;
using System.Collections.Generic;

namespace FoxKit.FormatHandlers.LocatorArray
{
    public delegate void HashIdentifiedDelegate(uint hashValue, string stringLiteral);

    public class HashManager
    {
        public Dictionary<uint, string> HashLookupTable = new Dictionary<uint, string>();
        public Dictionary<uint, string> UsedHashes = new Dictionary<uint, string>();

        public static uint HashString(string text)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));
            const ulong seed0 = 0x9ae16a3b2f90404f;
            ulong seed1 = text.Length > 0 ? (uint)((text[0]) << 16) + (uint)text.Length : 0;
            return (uint)(CityHash.CityHash.CityHash64WithSeeds(text + "\0", seed0, seed1) & 0xFFFFFFFFFFFF);
        }

        /// <summary>
        /// Whenever a hash is identified, keep track of it so we can output a list of all matching hashes.
        /// </summary>
        /// <param name="hashValue">Hash value that was matched.</param>
        /// <param name="stringLiteral">String literal the hashValue matches.</param>
        public void OnHashIdentified(uint hashValue, string stringLiteral)
        {
            if (!UsedHashes.ContainsKey(hashValue))
            {
                UsedHashes.Add(hashValue, stringLiteral);
            }
        }
    }
}