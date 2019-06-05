using System.Collections.Generic;
using System.Linq;
using BLL.Infrastructure;
using DAL.Model;

namespace DAL.Repository
{
    public class ArticleRepository : IRepository<ArticleIdentity>
    {
        private readonly Context _context;

        public ArticleRepository(Context context) => _context = context;

        public void Add(ArticleIdentity item) => _context.ArticleIdentities.Add(item);

        public void Remove(int index) => _context.ArticleIdentities.Remove(_context.ArticleIdentities.Find(index));

        public IEnumerable<ArticleIdentity> GetAll() => _context.ArticleIdentities.ToList();

        public void Dispose() => _context?.Dispose();
    }
}