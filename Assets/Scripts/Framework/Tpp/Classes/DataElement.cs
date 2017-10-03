using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using UnityEditor;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    /// <summary>
    /// A nameless Entity which belongs to another Entity.
    /// </summary>
    public abstract class DataElement<T> : Entity where T : Entity
    {
        [EntityProperty("owner", FoxDataType.EntityHandle)]
        public T Owner;

        protected DataElement() : base(false)
        {
            
        }

        protected DataElement(bool hasTransform) : base(hasTransform)
        {
        }

        public override void OnLoaded()
        {
            base.OnLoaded();
            if (Owner == null) return;

            gameObject.name = Owner.name + " " + GetType().Name;
            transform.SetParent(Owner.transform);
        }
    }
}