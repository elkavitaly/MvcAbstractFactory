using System;
using BLL.Model;

namespace BLL.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Article> ArticleRepository { get; }
        IRepository<Newspaper> NewspaperRepository { get; }
        void Save();
    }
}