namespace Bjma.Utility.DataAccess
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public delegate string[] CollectionPersistenceStrategyDelegate<in T>(IEnumerable<T> itemsToPersist) where T : IAggregateRoot, ISerializable;
}