using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class SoundDataFileInfo : Data
    {
        [EntityProperty("loadBanks", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> LoadBanks;

        [EntityProperty("prepareBanks", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> PrepareBanks;

        [EntityProperty("prepareEvents", FoxDataType.String, FoxContainerType.DynamicArray)]
        public List<String> PrepareEvents;
    }
}
