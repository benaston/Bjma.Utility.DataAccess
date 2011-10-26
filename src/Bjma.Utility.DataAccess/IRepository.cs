namespace Bjma.Utility.DataAccess
{
    using System.Collections.Generic;

    /// <summary>
    /// Should we bother trying to expose 
    /// full CRUD functoinality here?
    /// </summary>
    public interface IRepository<TItem, TItemId, in TQuery>
    {
        TItemId Add(TItem @object);

        TItem GetById(TItemId id);

        IEnumerable<TItem> GetByIds(IEnumerable<TItemId> ids);

        IEnumerable<TItem> GetByQuery(TQuery query, int pageSize = 10, int startPage = 1, int numberOfPages = 1);

        void Update(TItem @object);

        TItemId Remove(IEnumerable<TItemId> id);
    }
}