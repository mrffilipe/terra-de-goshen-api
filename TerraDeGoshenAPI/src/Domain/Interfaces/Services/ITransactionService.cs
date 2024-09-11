namespace TerraDeGoshenAPI.src.Domain
{
    public interface ITransactionService
    {
        Task<Transaction> GetTransactionByIdAsync(Guid id);
        Task<IList<Transaction>> GetTransactionsByCustomerAsync(Guid customerId);
        Task<IList<Transaction>> GetTransactionsByProductAsync(Guid productId);
    }
}