using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class ShearTransformEntity : DataElement<Data>
    {
        [EntityProperty("shearTransform_shear", FoxDataType.Vector3, FoxContainerType.StaticArray)]
        public Vector3 ShearTransform_shear;
    }
}
