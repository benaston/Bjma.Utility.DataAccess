namespace Bjma.Utility.DataAccess
{
    using System.Runtime.Serialization;

    public interface IPersistenceStrategy<in TAggregateRoot> where TAggregateRoot : IAggregateRoot, ISerializable
    {
        string Persist(TAggregateRoot itemToPersist);
    }
}