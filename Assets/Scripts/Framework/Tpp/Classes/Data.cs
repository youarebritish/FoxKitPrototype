using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;

namespace FoxKit.Framework.Tpp.Classes
{
    /// <summary>
    /// A named Entity with a reference to its owning DataSet.
    /// </summary>
    public abstract class Data : Entity
    {
        /// <summary>
        /// Name of the Entity. Will appear as the GameObject's name in the inspector.
        /// </summary>
        [EntityProperty("name", FoxDataType.String)]
        public string Name;

        /// <summary>
        /// The DataSet this Entity belongs to.
        /// </summary>
        [EntityProperty("dataSet", FoxDataType.EntityHandle)]
        public DataSet DataSet;

        protected Data() : this(false)
        {
            ;
        }

        protected Data(bool hasTransform) : base(hasTransform)
        {
            ;
        }

        public override void OnLoaded()
        {
            base.OnLoaded();
            gameObject.name = Name;
        }
    }
}