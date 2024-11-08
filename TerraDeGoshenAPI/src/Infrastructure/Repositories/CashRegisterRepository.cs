﻿using Microsoft.EntityFrameworkCore;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class CashRegisterRepository : ICashRegisterRepository
    {
        private readonly ApplicationDbContext _context;

        public CashRegisterRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context), "Contexto de banco de dados não pode ser nulo.");
        }

        public async Task<Transaction> AddTransactionAsync(Transaction transaction)
        {
            if (transaction == null)
            {
                throw new ArgumentNullException(nameof(transaction), "A transação não pode ser nula.");
            }

            var cashRegister = await _context.CashRegisters
                                             .FirstOrDefaultAsync(c => c.Id == transaction.CashRegisterId);

            if (cashRegister == null)
            {
                return null;
            }

            cashRegister.AddTransaction(transaction);

            await _context.Transactions.AddAsync(transaction);

            await _context.SaveChangesAsync();

            return transaction;
        }

        public async Task<CashRegister> GetCashRegisterAsync()
        {
            return await _context.CashRegisters.FirstOrDefaultAsync();
        }

        public async Task<MoneyVO> GetCurrentBalanceAsync(Guid cashRegisterId)
        {
            var cashRegister = await _context.CashRegisters
                                             .FirstOrDefaultAsync(c => c.Id == cashRegisterId);

            return cashRegister?.GetCurrentBalance();
        }

        public async Task<IList<Transaction>> GetTransactionsAsync(Guid cashRegisterId, DateTime? startDate = null, DateTime? endDate = null)
        {
            var query = _context.Transactions
                                .Where(t => t.CashRegisterId == cashRegisterId);

            if (startDate.HasValue)
            {
                query = query.Where(t => t.CreatedAt >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(t => t.CreatedAt <= endDate.Value);
            }

            return await query.ToListAsync();
        }
    }
}