namespace Bjma.Utility.DataAccess
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public delegate IEnumerable<T> CollectionRetrievalStrategyDelegate<out T>(string[] id) where T : IAggregateRoot, ISerializable;
}