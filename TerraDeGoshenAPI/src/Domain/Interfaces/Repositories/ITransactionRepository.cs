namespace TerraDeGoshenAPI.src.Domain
{
    public interface ITransactionRepository
    {
        Task<Transaction> GetTransactionByIdAsync(Guid id);
        Task<IList<Transaction>> GetTransactionsByCustomerAsync(Guid customerId);
        Task<IList<Transaction>> GetTransactionsByProductAsync(Guid productId);
    }
}