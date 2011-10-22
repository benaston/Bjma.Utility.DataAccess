namespace Bjma.Utility.DataAccess
{
    using System;
    using System.Collections.Generic;

    public interface IRepository<T> //  where T : new()
    {
        T GetById(Guid id);
        IEnumerable<T> GetByIds(IEnumerable<Guid> ids);
        IEnumerable<T> GetByFreeText(string query, int startPage, int numberOfPages);
        Guid Save(T objectToSave);
    }
}