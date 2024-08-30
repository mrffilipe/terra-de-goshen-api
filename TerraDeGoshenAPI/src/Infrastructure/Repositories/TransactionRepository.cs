using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class TransactionRepository : ITransactionRepository
    {
        public Task<Transaction> AddTransactionAsync(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Task<Transaction> GetTransactionByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Transaction>> GetTransactionsByCashRegisterAsync(Guid cashRegisterId, DateTime? startDate = null, DateTime? endDate = null)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Transaction>> GetTransactionsByCustomerAsync(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Transaction>> GetTransactionsByProductAsync(Guid productId)
        {
            throw new NotImplementedException();
        }
    }
}