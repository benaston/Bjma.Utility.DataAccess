namespace Bjma.Utility.DataAccess
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// NOTE: BA; possibly expose as IPersistenceStrategy<TRoot>
    /// and IRetrievalStrategy<TRoot>, these can be IOC'd up with
    /// the relevant cache/local/remote db calls built in.
    /// e.g. profile information might be persistent locally,
    /// whilst domain object persistence might be sent
    /// Responsible for defining the interface for types that provide
    /// access to functionality to persist and retrieve objects to/from
    /// long-term storage.
    /// </summary>
    public interface IPersistentMemory //rename to repository?
    {
        string Save<T>(T @object) where T : IAggregateRoot, ISerializable; //is ISerializable needed here?

        T Retrieve<T>(string id) where T : IAggregateRoot;
        
        IEnumerable<T> Retrieve<T>(string[] id) where T : IAggregateRoot;
    }
}