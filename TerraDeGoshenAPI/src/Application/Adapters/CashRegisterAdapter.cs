﻿using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class CashRegisterAdapter : ICashRegisterAdapter
    {
        private readonly ICashRegisterService _cashRegisterService;
        private readonly IMapper _mapper;

        public CashRegisterAdapter(ICashRegisterService cashRegisterService, IMapper mapper)
        {
            _cashRegisterService = cashRegisterService;
            _mapper = mapper;
        }

        public async Task<TransactionResponseDTO> AddTransactionAsync(TransactionCreateDTO transaction)
        {
            var mappedTransaction = _mapper.Map<Transaction>(transaction);

            mappedTransaction = await _cashRegisterService.AddTransactionAsync(mappedTransaction); 

            return _mapper.Map<TransactionResponseDTO>(mappedTransaction);
        }

        public async Task<decimal> GetCurrentBalanceAsync(Guid cashRegisterId)
        {
            var balance = await _cashRegisterService.GetCurrentBalanceAsync(cashRegisterId);

            return balance.Amount;
        }

        public async Task<IList<TransactionResponseDTO>> GetTransactionsAsync(Guid cashRegisterId, DateTime? startDate = null, DateTime? endDate = null)
        {
            var transactions = await _cashRegisterService.GetTransactionsAsync(cashRegisterId, startDate, endDate);

            return _mapper.Map<IList<TransactionResponseDTO>>(transactions);
        }
    }
}