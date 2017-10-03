using FoxKit.Framework.Fox;
using FoxTool.Fox.Types;
using UnityEngine;

namespace FoxKit.Framework.Tpp.Classes
{
    /// <summary>
    /// An DataElement with an owner, location, rotation, and scale.
    /// </summary>
    public class TransformEntity : DataElement<Data>
    {
        [EntityProperty("transform_scale", FoxDataType.Vector3)]
        public Vector3 Scale;

        [EntityProperty("transform_rotation_quat", FoxDataType.Quat)]
        public Quaternion RotQuat;

        [EntityProperty("transform_translation", FoxDataType.Vector3)]
        public Vector3 Translation;

        public TransformEntity() : base(true)
        {
            
        }

        public override void OnLoaded()
        {
            base.OnLoaded();

            transform.position = new Vector3(Translation.z, Translation.y, Translation.x);
            transform.rotation = new Quaternion(-RotQuat.z, -RotQuat.y, -RotQuat.x, RotQuat.w);
            transform.localScale = Scale;
        }
    }
}