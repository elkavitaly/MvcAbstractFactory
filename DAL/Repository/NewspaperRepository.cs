using System.Collections.Generic;
using System.Linq;
using BLL.Infrastructure;
using DAL.Model;

namespace DAL.Repository
{
    public class NewspaperRepository : IRepository<NewspaperIdentity>
    {
        private readonly Context _context;

        public NewspaperRepository(Context context) => _context = context;

        public void Add(NewspaperIdentity item) => _context.NewspaperIdentities.Add(item);

        public void Remove(int index) => _context.NewspaperIdentities.Remove(_context.NewspaperIdentities.Find(index));

        public IEnumerable<NewspaperIdentity> GetAll() => _context.NewspaperIdentities.ToList();

        public void Dispose() => _context?.Dispose();
    }
}