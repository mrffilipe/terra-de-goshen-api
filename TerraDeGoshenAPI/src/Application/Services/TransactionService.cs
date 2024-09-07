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
            if (transaction == null)
            {
                throw new ArgumentNullException(nameof(transaction));
            }

            var addedTransaction = await _transactionRepository.AddTransactionAsync(transaction);

            return addedTransaction;
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

        public async Task<IList<Transaction>> GetTransactionsByCashRegisterAsync(Guid cashRegisterId, DateTime? startDate = null, DateTime? endDate = null)
        {
            if (cashRegisterId == Guid.Empty)
            {
                throw new ArgumentException("ID do caixa inválido.", nameof(cashRegisterId));
            }

            var transactions = await _transactionRepository.GetTransactionsByCashRegisterAsync(cashRegisterId, startDate, endDate);

            return transactions;
        }
    }
}