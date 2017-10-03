using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class Material : Data
    {
        [EntityProperty("materialName", FoxDataType.String, FoxContainerType.StaticArray)]
        public String MaterialName;

        [EntityProperty("shader", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String Shader;

        [EntityProperty("diffuseTexture", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String DiffuseTexture;

        [EntityProperty("srmTexture", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String SrmTexture;

        [EntityProperty("normalTexture", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String NormalTexture;

        [EntityProperty("materialMapTexture", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String MaterialMapTexture;

        [EntityProperty("materialIndex", FoxDataType.UInt8, FoxContainerType.StaticArray)]
        public Byte MaterialIndex;

        [EntityProperty("diffuseColor", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color DiffuseColor;

        [EntityProperty("specularColor", FoxDataType.Color, FoxContainerType.StaticArray)]
        public Color SpecularColor;

        [EntityProperty("fmtrPath", FoxDataType.Path, FoxContainerType.StaticArray)]
        public String FmtrPath;

        [EntityProperty("residentFlag", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean ResidentFlag;
    }
}
