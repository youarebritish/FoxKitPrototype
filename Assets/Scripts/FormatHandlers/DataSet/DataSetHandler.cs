using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using FoxKit.Framework.Concurrency;
using FoxKit.Framework.FormatHandlers.DataSet;
using FoxKit.Framework.Fox;
using FoxTool.Fox;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace FoxKit.FormatHandlers.DataSet
{
    public class DataSetHandler : IFoxAssetHandler
    {
        private static readonly List<string> DecompilableExtensions = new List<string>
        {
            "bnd",
            "clo",
            "des",
            "evf",
            "fox2",
            "fsd",
            "lad",
            "parts",
            "ph",
            "phsd",
            "sdf",
            "sim",
            "tgt",
            "vdp",
            "veh",
            "vfxlf"
        };

        public List<string> Extensions => DecompilableExtensions;

        private static readonly Dictionary<ulong, string> GlobalHashNameDictionary = new Dictionary<ulong, string>();
        private readonly Dictionary<string, Type> entityTypes;
        private readonly ConcurrentDictionary<string, FoxEntity> unimplementedTypeTable;
        private readonly IUnityThreadCommandDispatcher commandDispatcher;

        public DataSetHandler(Dictionary<string, Type> entityTypeTable, 
            ConcurrentDictionary<string, FoxEntity> unimplementedTypeTable, 
            IUnityThreadCommandDispatcher unityThreadCommandDispatcher)
        {
            entityTypes = entityTypeTable;
            this.unimplementedTypeTable = unimplementedTypeTable;
            commandDispatcher = unityThreadCommandDispatcher;
        }

        public void Export(object asset, string path)
        {
            throw new NotImplementedException();
        }

        public void Import(Stream input, string path)
        {
            var lookupTable = new FoxLookupTable(GlobalHashNameDictionary);
            var foxFile = FoxFile.ReadFoxFile(input, lookupTable);

            IEntityReferenceResolver referenceResolver = new EntityReferenceResolver();
            Framework.Tpp.Classes.DataSet dataSet = null;

            // Load each Entity.
            ICollection<Entity> entities = new List<Entity>();
            foreach (var entry in foxFile.Entities)
            {
                var entity = EntityFactory.MakeEntity(entry, entityTypes, unimplementedTypeTable, commandDispatcher, referenceResolver);

                if (entity != null)
                {
                    entities.Add(entity);
                }

                if (!(entity is Framework.Tpp.Classes.DataSet)) continue;
                dataSet = entity as Framework.Tpp.Classes.DataSet;
                dataSet.SetPath(path);
            }

            // Call OnLoaded() on the new Entities.
            var autoResetEvent = commandDispatcher.DispatchCommand(new InitializeEntities(dataSet, entities));
            autoResetEvent.WaitOne();

            // Generate new Entity classes.
            foreach (var unimplementedType in unimplementedTypeTable)
            {
                Debug.Log("Generating C# class for type " + unimplementedType.Key);
                EntityClassGenerator.GenerateEntityClass(unimplementedType.Value);
            }
        }
    }
}