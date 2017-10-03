using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace FoxKit.Framework.Concurrency
{
    public delegate void DeliverNewScriptableObjectDelegate<in T>(T newScriptableObject) where T : ScriptableObject;

    public class CreateScriptableObject<T> : IUnityThreadCommand where T : ScriptableObject
    {
        private readonly string assetPath;
        private readonly DeliverNewScriptableObjectDelegate<T> objectCreatedCallback;

        public CreateScriptableObject(string assetPath, DeliverNewScriptableObjectDelegate<T> onCreatedDelegate)
        {
            if (onCreatedDelegate == null)
            {
                throw new ArgumentNullException(nameof(onCreatedDelegate));
            }
            this.assetPath = assetPath;
            objectCreatedCallback = onCreatedDelegate;
        }

        public void Execute()
        {
            var createdObject = ScriptableObject.CreateInstance<T>();
            AssetDatabase.CreateAsset(createdObject, Path.GetDirectoryName(assetPath) + "/" + Path.GetFileNameWithoutExtension(assetPath) + ".asset");
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            objectCreatedCallback.Invoke(createdObject);
        }
    }
}
