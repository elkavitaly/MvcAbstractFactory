using BLL.Infrastructure;
using DAL;

namespace UI.Models
{
    public static class Initializer
    {
        private static IRepositoryFactory _factory = null;

        public static IRepositoryFactory Initialize() => _factory ?? (_factory = new RepositoryFactory());
    }
}