namespace Bjma.Utility.DataAccess
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Responsible for defining functions providing 
    /// persistence functionality for objects of type T.
    /// </summary>
    /// <returns>The ID of the persisted object.</returns>
    public delegate T RetrievalStrategyDelegate<out T>(string id) where T : IAggregateRoot, ISerializable;
}