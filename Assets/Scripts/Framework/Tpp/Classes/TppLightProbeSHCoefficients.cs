using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppLightProbeSHCoefficients : Data
    {
        [EntityProperty("filePath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String FilePath;

        [EntityProperty("lpshFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String LpshFile;
    }
}
