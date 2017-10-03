using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    /// <summary>
    /// A TransformData with a size.
    /// </summary>
    [TppClass(ClassCategory.Locator)]
    public class Locator : TransformData
    {
        /// <summary>
        /// Radius?
        /// </summary>
        [EntityProperty("size", FoxDataType.Float)]
        public float Size = 1.0f;

        private void OnDrawGizmosSelected()
        {
            Gizmos.DrawWireSphere(transform.position, Size);
        }
    }
}