﻿namespace MDR.Data.Sql.Repositories
{
    public interface IRepository<T>
    {
        void Add(T entity);
    }
}
