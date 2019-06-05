namespace BLL.Infrastructure
{
    public interface IRepositoryFactory
    {
        IUnitOfWork Initialize { get; }
    }
}