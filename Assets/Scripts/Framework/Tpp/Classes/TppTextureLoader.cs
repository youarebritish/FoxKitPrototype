using FoxKit.Framework.Fox;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types;
using System.Collections.Generic;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppTextureLoader : Data
    {
        [EntityProperty("textures", FoxDataType.Path, FoxContainerType.StringMap)]
        public Dictionary<string, string> Textures;

        [EntityProperty("forceLargeTextures", FoxDataType.Path, FoxContainerType.StringMap)]
        public Dictionary<string, string> ForceLargeTextures;
    }
}