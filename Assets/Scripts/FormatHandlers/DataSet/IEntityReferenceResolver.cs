using FoxKit.Framework.Fox;

namespace FoxKit.FormatHandlers.DataSet
{
    /// <summary>
    /// Assigns the reference to a requested Entity once it's found.
    /// </summary>
    /// <param name="requestedEntityReference">The requested Entity.</param>
    public delegate void AssignReferenceDelegate(Entity requestedEntityReference);

    /// <summary>
    /// Provides a mechanism for resolving extant references to entities in a property.
    /// Useful when an entity with a FoxEntityPtr or FoxEntityHandle property is loaded but the referenced entity hasn't been loaded yet.
    /// In that case, wait until the referenced entity has been loaded and call ResolveReference() with it.
    /// </summary>
    public interface IEntityReferenceResolver
    {
        /// <summary>
        /// Requests a reference to another Entity.
        /// </summary>
        /// <param name="referenceAssignmentDelegate">Callback to assign the Entity reference once it's found.</param>
        /// <param name="referencedEntityAddress">Address of the Entity whose reference we're requesting.</param>
        void RequestReference(AssignReferenceDelegate referenceAssignmentDelegate, ulong referencedEntityAddress);
        
        /// <summary>
        /// Registers an Entity reference to assign to anyone listening for it.
        /// </summary>
        /// <param name="entityAddress">The address of the entity instance.</param>
        /// <param name="referencedEntity">The entity instance.</param>
        void RegisterReference(ulong entityAddress, Entity referencedEntity);
    }
}
