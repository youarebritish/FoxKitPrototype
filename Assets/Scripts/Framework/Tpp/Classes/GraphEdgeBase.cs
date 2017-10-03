using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    public abstract class GraphEdgeBase : DataElement<PathBase>
    {
        [EntityProperty("prevNode", FoxDataType.EntityHandle)]
        public GraphNodeBase PrevNode;

        [EntityProperty("nextNode", FoxDataType.EntityHandle)]
        public GraphNodeBase NextNode;
    }
}