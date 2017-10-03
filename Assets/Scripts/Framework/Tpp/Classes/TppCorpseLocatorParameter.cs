using System;
using System.Collections.Generic;
using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types.Structs;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class TppCorpseLocatorParameter : DataElement<Data>
    {
        [EntityProperty("identifier", FoxDataType.String, FoxContainerType.StaticArray)]
        public String Identifier;

        [EntityProperty("isEmplaced", FoxDataType.Bool, FoxContainerType.StaticArray)]
        public Boolean IsEmplaced;
    }
}
