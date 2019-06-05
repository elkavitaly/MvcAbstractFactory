using System;
using System.Collections.Generic;

namespace BLL.Infrastructure
{
    public interface IRepository<T> : IDisposable
    {
        void Add(T item);
        void Remove(int index);
        IEnumerable<T> GetAll();
    }
}