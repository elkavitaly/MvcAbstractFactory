namespace DAL
{
    public static class RepositoryFactoryInitializer
    {
        public static void Initialize() => BLL.Infrastructure.RepositoryFactory.SetRepositoryFactory(new RepositoryFactory());
    }
}