﻿namespace TerraDeGoshenAPI.src.Domain
{
    public interface ICashRegisterRepository
    {
        Task AddTransactionAsync(Guid cashRegisterId, Transaction transaction);
        Task<MoneyVO> GetCurrentBalanceAsync(Guid cashRegisterId);
        Task<IList<Transaction>> GetTransactionsAsync(Guid cashRegisterId, DateTime? startDate = null, DateTime? endDate = null);
    }
}