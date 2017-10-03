using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    public class BoxShape : TransformData
    {
        protected override void OnDrawGizmos()
        {
            base.OnDrawGizmos();
            Gizmos.DrawWireCube(transform.position, transform.localScale);
        }
    }
}
