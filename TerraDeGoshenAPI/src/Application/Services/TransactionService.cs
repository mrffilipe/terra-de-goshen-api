using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;
        private readonly ICashRegisterService _cashRegisterService;

        public TransactionService(ITransactionRepository transactionRepository, ICashRegisterService cashRegisterService)
        {
            _transactionRepository = transactionRepository ?? throw new ArgumentNullException(nameof(transactionRepository), "O repositório de transações não pode ser nulo.");
            _cashRegisterService = cashRegisterService ?? throw new ArgumentNullException(nameof(cashRegisterService), "O serviço de caixa não pode ser nulo.");
        }

        public async Task<Transaction> GetTransactionByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("O ID da transação é inválido.", nameof(id));
            }

            var transaction = await _transactionRepository.GetTransactionByIdAsync(id);
            if (transaction == null)
            {
                throw new KeyNotFoundException($"Transação com o ID {id} não foi encontrada.");
            }

            return transaction;
        }

        public async Task<IList<Transaction>> GetTransactionsByCustomerAsync(Guid customerId)
        {
            if (customerId == Guid.Empty)
            {
                throw new ArgumentException("O ID do cliente é inválido.", nameof(customerId));
            }

            var transactions = await _transactionRepository.GetTransactionsByCustomerAsync(customerId);
            if (transactions == null || !transactions.Any())
            {
                throw new KeyNotFoundException($"Nenhuma transação encontrada para o cliente com ID {customerId}.");
            }

            return transactions;
        }

        public async Task<IList<Transaction>> GetTransactionsByProductAsync(Guid productId)
        {
            if (productId == Guid.Empty)
            {
                throw new ArgumentException("O ID do produto é inválido.", nameof(productId));
            }

            var transactions = await _transactionRepository.GetTransactionsByProductAsync(productId);
            if (transactions == null || !transactions.Any())
            {
                throw new KeyNotFoundException($"Nenhuma transação encontrada para o produto com ID {productId}.");
            }

            return transactions;
        }
    }
}