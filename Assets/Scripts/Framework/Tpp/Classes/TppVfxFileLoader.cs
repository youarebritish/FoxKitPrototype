using FoxKit.Framework.Fox;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types;
using System.Collections.Generic;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppVfxFileLoader : Data
    {
        [EntityProperty("vfxFile", FoxDataType.FilePtr)]
        public string VfxFile;

        [EntityProperty("materialSoundList", FoxDataType.String, FoxContainerType.StringMap)]
        public Dictionary<string, string> MaterialSoundList;

        [EntityProperty("vfxFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, string> VfxFiles;

        [EntityProperty("geoMaterialFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, string> GeoMaterialFiles;

        [EntityProperty("otherFiles", FoxDataType.FilePtr, FoxContainerType.StringMap)]
        public Dictionary<string, string> OtherFiles;
    }
}