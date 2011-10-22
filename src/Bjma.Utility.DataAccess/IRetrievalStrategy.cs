namespace Bjma.Utility.DataAccess
{
    using System.Runtime.Serialization;

    public interface IRetrievalStrategy<out TAggregateRoot> where TAggregateRoot : IAggregateRoot, ISerializable
    {
        TAggregateRoot Retrieve(string ids);
    }
}