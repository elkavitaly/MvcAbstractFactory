using AutoMapper;
using BLL.Infrastructure;
using BLL.Model;
using DAL.Model;
using DAL.Repository;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context = new Context();

        public IRepository<Article> ArticleRepository =>
            MapDepartment<IRepository<Article>, IRepository<ArticleIdentity>>(new ArticleRepository(_context));

        public IRepository<Newspaper> NewspaperRepository =>
            MapDepartment<IRepository<Newspaper>, IRepository<NewspaperIdentity>>(new NewspaperRepository(_context));

        public void Save() => _context.SaveChanges();

        public void Dispose() => _context?.Dispose();

        private static TD MapDepartment<TD, TDf>(TDf entity)
        {
#pragma warning disable 618
            Mapper.Initialize(config => config.CreateMap<TDf, TD>());
#pragma warning restore 618
            return Mapper.Map<TD>(entity);
        }
    }
}