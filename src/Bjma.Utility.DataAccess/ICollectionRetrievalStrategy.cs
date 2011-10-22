namespace Bjma.Utility.DataAccess
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public interface ICollectionRetrievalStrategy<out TAggregateRoot> where TAggregateRoot : IAggregateRoot, ISerializable
    {
        IEnumerable<TAggregateRoot> Retrieve(string[] ids);
    }
}