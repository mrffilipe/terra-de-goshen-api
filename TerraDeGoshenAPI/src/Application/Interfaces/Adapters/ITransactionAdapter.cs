namespace TerraDeGoshenAPI.src.Domain
{
    public interface ITransactionAdapter
    {
        Task<Transaction> AddTransactionAsync(Transaction transaction);
        Task<Transaction> GetTransactionByIdAsync(Guid id);
        Task<IList<Transaction>> GetTransactionsByCustomerAsync(Guid customerId);
        Task<IList<Transaction>> GetTransactionsByProductAsync(Guid productId);
    }
}