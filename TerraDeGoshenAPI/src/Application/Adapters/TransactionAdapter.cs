using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class TransactionAdapter : ITransactionAdapter
    {
        private readonly ITransactionService _transactionService;
        private readonly IMapper _mapper;

        public TransactionAdapter(ITransactionService transactionService, IMapper mapper)
        {
            _transactionService = transactionService;
            _mapper = mapper;
        }

        public async Task<TransactionResponseDTO> GetTransactionByIdAsync(Guid id)
        {
            var transaction = await _transactionService.GetTransactionByIdAsync(id);

            return _mapper.Map<TransactionResponseDTO>(transaction);
        }

        public async Task<IList<TransactionResponseDTO>> GetTransactionsByCustomerAsync(Guid customerId)
        {
            var transactions = await _transactionService.GetTransactionsByCustomerAsync(customerId);

            return _mapper.Map<TransactionResponseDTO[]>(transactions);
        }

        public async Task<IList<TransactionResponseDTO>> GetTransactionsByProductAsync(Guid productId)
        {
            var transactions = await _transactionService.GetTransactionsByProductAsync(productId);

            return _mapper.Map<TransactionResponseDTO[]>(transactions);
        }
    }
}