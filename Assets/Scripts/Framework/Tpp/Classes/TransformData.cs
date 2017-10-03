using FoxKit.Framework.Fox;
using FoxKit.Framework.Tpp.WorldObjects;
using FoxTool.Fox.Containers;
using FoxTool.Fox.Types;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    /// <summary>
    /// Base class for an Entity with a world transform. It may have a parent TransformData, and may be the parent of other TransformData Entities.
    /// </summary>
    public abstract class TransformData : Data
    {
        [EntityProperty("parent", FoxDataType.EntityHandle)]
        public TransformData Parent;

        [EntityProperty("transform", FoxDataType.EntityPtr)]
        public TransformEntity Transform;

        [EntityProperty("shearTransform", FoxDataType.EntityPtr)]
        public TransformEntity ShearTransform;

        [EntityProperty("pivotTransform", FoxDataType.EntityPtr)]
        public TransformEntity PivotTransform;

        [EntityProperty("children", FoxDataType.EntityHandle, FoxContainerType.List)]
        public List<TransformData> Children;

        [EntityProperty("flags", FoxDataType.UInt32)]
        public uint Flags;

        public TransformData() : base(true)
        {
            ;
        }

        public override void OnLoaded()
        {
            base.OnLoaded();

            // Not sure why it's possible for a TransformData to have a null Transform, but hey, I didn't design Fox Engine.
            if (Transform == null) return;

            if (Parent != null)
            {
                transform.SetParent(Parent.transform);
            }
            transform.localPosition = new Vector3(Transform.Translation.z, Transform.Translation.y, Transform.Translation.x);
            transform.localRotation = new Quaternion(-Transform.RotQuat.z, -Transform.RotQuat.y, -Transform.RotQuat.x, Transform.RotQuat.w);
            transform.localScale = Transform.Scale;
        }

        public List<TransformData> GetChildren()
        {
            return Children;
        }
    }
}
