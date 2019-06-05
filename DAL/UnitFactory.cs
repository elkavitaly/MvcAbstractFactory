using BLL.Infrastructure;

namespace DAL
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public IUnitOfWork Initialize => new UnitOfWork();
    }
}