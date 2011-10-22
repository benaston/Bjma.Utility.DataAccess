namespace Bjma.Utility.DataAccess
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public interface ICollectionPersistenceStrategy<in TAggregateRoot> where TAggregateRoot : IAggregateRoot, ISerializable
    {
        string[] Persist(IEnumerable<TAggregateRoot> itemsToPersist);
    }
}