using System.Collections.Generic;
using System.Diagnostics;
using FoxKit.Framework.Fox;
using FoxKit.Framework.Tpp.Classes;

namespace FoxKit.FormatHandlers.DataSet
{
    public class EntityReferenceResolver : IEntityReferenceResolver
    {
        private readonly Dictionary<ulong, Entity> registeredEntityTable = new Dictionary<ulong, Entity>();
        private readonly Dictionary<ulong, HashSet<AssignReferenceDelegate>> entityRequestTable = new Dictionary<ulong, HashSet<AssignReferenceDelegate>>();

        public void RequestReference(AssignReferenceDelegate referenceAssignmentDelegate, ulong referencedEntityAddress)
        {
            // If this address points to an Entity which has already been registered, assign the reference.
            Entity entityReference;
            if (registeredEntityTable.TryGetValue(referencedEntityAddress, out entityReference))
            {
                referenceAssignmentDelegate.Invoke(entityReference);
            }
            // Otherwise, add a new entry to the entityRequestTable.
            else
            {
                // If there's already a set of requesters waiting for the same Entity, add the new requester to it.
                HashSet<AssignReferenceDelegate> requesters;
                if (entityRequestTable.TryGetValue(referencedEntityAddress, out requesters))
                {
                    requesters.Add(referenceAssignmentDelegate);
                }
                // If not, make a new set, add the requester to it, and add the set to the entityRequestTable.
                else
                {
                    requesters = new HashSet<AssignReferenceDelegate> {referenceAssignmentDelegate};
                    entityRequestTable.Add(referencedEntityAddress, requesters);
                }
            }
        }

        public void RegisterReference(ulong entityAddress, Entity referencedEntity)
        {
            registeredEntityTable.Add(entityAddress, referencedEntity);

            HashSet<AssignReferenceDelegate> requesters;
            if (entityRequestTable.TryGetValue(entityAddress, out requesters))
            {
                foreach (var request in requesters)
                {
                    request.Invoke(referencedEntity);
                }
            }
            // Since this Entity reference has been resolved, we can remove requests for it from the entityRequestTable.
            entityRequestTable.Remove(entityAddress);
        }
    }
}
