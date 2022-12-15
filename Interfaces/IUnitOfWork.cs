namespace FreshFood.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductsRepository ProductsRepository { get; }
        int Complete();
    }
}