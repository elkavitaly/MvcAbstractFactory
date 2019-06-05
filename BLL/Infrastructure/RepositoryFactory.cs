namespace BLL.Infrastructure
{
    public static class RepositoryFactory
    {
        public static IRepositoryFactory Instance { get; private set; }
        
        public static void SetRepositoryFactory(IRepositoryFactory factory) => Instance = factory;
    }
}