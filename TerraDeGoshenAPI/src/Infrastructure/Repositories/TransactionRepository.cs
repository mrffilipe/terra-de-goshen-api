using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class TransactionRepository : ITransactionRepository
    {
        public async Task<Transaction> AddAsync(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public async Task<Transaction> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Transaction>> GetByCustomerIdAsync(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Transaction>> GetByProductIdAsync(Guid productId)
        {
            throw new NotImplementedException();
        }
    }
}