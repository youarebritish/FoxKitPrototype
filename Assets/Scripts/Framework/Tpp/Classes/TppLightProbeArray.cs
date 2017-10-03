using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppLightProbeArray : TransformData
    {
        [EntityProperty("drawRejectionLevels", FoxDataType.Int32, FoxContainerType.DynamicArray)]
        public List<Int32> DrawRejectionLevels;

        [EntityProperty("relatedLights", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> RelatedLights;

        [EntityProperty("shDatas", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> ShDatas;

        [EntityProperty("lightArrayFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String LightArrayFile;
    }
}
