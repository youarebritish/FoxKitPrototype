using System;
using FoxKit.Framework.Concurrency;
using FoxKit.Framework.Fox;
using UnityEditor;
using UnityEngine;

namespace FoxKit.Framework.FormatHandlers.Model
{
    /// <summary>
    /// TODO: Make this not a lazy hack
    /// </summary>
    public class CreateMesh : IUnityThreadCommand
    {
        private readonly Action createMeshCallback;

        public CreateMesh(Action createMeshCallback)
        {
            this.createMeshCallback = createMeshCallback;
        }

        public void Execute()
        {
            createMeshCallback.Invoke();
        }
    }
}
