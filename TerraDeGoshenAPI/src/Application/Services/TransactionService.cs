using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public async Task<Transaction> AddTransactionAsync(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public async Task<Transaction> GetTransactionByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Transaction>> GetTransactionsByCustomerAsync(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Transaction>> GetTransactionsByProductAsync(Guid productId)
        {
            throw new NotImplementedException();
        }
    }
}