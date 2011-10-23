namespace Bjma.Utility.DataAccess
{
    using System;
    using System.Collections.Generic;

    public interface IRepository<T>
    {
        T GetById(string id);

        IEnumerable<T> GetByIds(IEnumerable<string> ids);

        IEnumerable<T> GetByFreeText(string query, int pageSize, int startPage, int numberOfPages);

        Guid Save(T objectToSave);
    }
}