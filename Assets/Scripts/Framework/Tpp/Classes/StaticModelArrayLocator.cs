using FoxKit.Framework.Fox;
using FoxKit.Framework.Tpp.Classes;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.WorldObjects
{
    public class StaticModelArrayLocator : TransformData
    {
        [EntityProperty("viewgroup", FoxDataType.String, isDynamic: true)]
        public string ViewGroup;
    }
}