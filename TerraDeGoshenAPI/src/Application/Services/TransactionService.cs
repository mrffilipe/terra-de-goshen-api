using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly ICashRegisterService _cashRegisterService;

        public TransactionService(ITransactionRepository transactionRepository, ICashRegisterService cashRegisterService)
        {
            _transactionRepository = transactionRepository;
            _cashRegisterService = cashRegisterService;
        }

        public async Task<Transaction> GetTransactionByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("ID inválido.", nameof(id));
            }

            var transaction = await _transactionRepository.GetTransactionByIdAsync(id);
            if (transaction == null)
            {
                throw new KeyNotFoundException($"Transação com ID {id} não encontrada.");
            }

            return transaction;
        }

        public async Task<IList<Transaction>> GetTransactionsByCustomerAsync(Guid customerId)
        {
            if (customerId == Guid.Empty)
            {
                throw new ArgumentException("ID do cliente inválido.", nameof(customerId));
            }

            var transactions = await _transactionRepository.GetTransactionsByCustomerAsync(customerId);

            return transactions;
        }

        public async Task<IList<Transaction>> GetTransactionsByProductAsync(Guid productId)
        {
            if (productId == Guid.Empty)
            {
                throw new ArgumentException("ID do produto inválido.", nameof(productId));
            }

            var transactions = await _transactionRepository.GetTransactionsByProductAsync(productId);

            return transactions;
        }
    }
}