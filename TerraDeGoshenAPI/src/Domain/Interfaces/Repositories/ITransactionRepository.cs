namespace TerraDeGoshenAPI.src.Domain
{
    public interface ITransactionRepository
    {
        Task<Transaction> AddAsync(Transaction transaction);
        Task<Transaction> GetByIdAsync(Guid id);
        Task<IList<Transaction>> GetByCustomerIdAsync(Guid customerId);
        Task<IList<Transaction>> GetByProductIdAsync(Guid productId);
    }
}