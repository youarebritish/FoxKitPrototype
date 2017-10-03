using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class PhysicsDescription : Data
    {
        [EntityProperty("depends", FoxDataType.EntityLink, FoxContainerType.DynamicArray)]
        public List<FoxEntityLink> Depends;

        [EntityProperty("partName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String PartName;

        [EntityProperty("buildType", FoxDataType.String, FoxContainerType.StaticArray)]
        public String BuildType;

        [EntityProperty("physicsFile", FoxDataType.FilePtr, FoxContainerType.StaticArray)]
        public String PhysicsFile;
    }
}
