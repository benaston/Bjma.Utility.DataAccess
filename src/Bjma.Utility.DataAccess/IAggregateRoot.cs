namespace Bjma.Utility.DataAccess
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Responsible for providing a type to implement 
    /// to indicate a type is considered suitable for 
    /// persistence to long-term storage.
    /// </summary>
    public interface IAggregateRoot : ISerializable
    {
        string Id { get; set; } //was_id per CouchDb

        string Revision { get; set; } //was _rev per CouchDb
    }
}