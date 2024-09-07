using Microsoft.EntityFrameworkCore;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Infrastructure
{
    public class DebtRepository : IDebtRepository
    {
        private readonly ApplicationDbContext _context;

        public DebtRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Debt> AddDebtAsync(Debt debt)
        {
            if (debt == null)
            {
                throw new ArgumentNullException(nameof(debt));
            }

            await _context.Debts.AddAsync(debt);
            await _context.SaveChangesAsync();

            return debt;
        }

        public async Task<Debt> GetDebtByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("ID inválido.", nameof(id));
            }

            var debt = await _context.Debts
                                     .Include(d => d.Installments)
                                     .FirstOrDefaultAsync(d => d.Id == id);

            if (debt == null)
            {
                throw new KeyNotFoundException($"Dívida com ID {id} não encontrada.");
            }

            return debt;
        }

        public async Task<IList<Debt>> GetDebtsByCustomerAsync(Guid customerId)
        {
            if (customerId == Guid.Empty)
            {
                throw new ArgumentException("ID do cliente inválido.", nameof(customerId));
            }

            return await _context.Debts
                                 .Where(d => d.CustomerId == customerId)
                                 .Include(d => d.Installments)
                                 .ToListAsync();
        }

        public async Task<IList<Debt>> GetAllDebtsAsync(DateTime? startDate = null, DateTime? endDate = null, bool? isPaid = null)
        {
            var query = _context.Debts.Include(d => d.Installments).AsQueryable();

            if (startDate.HasValue)
            {
                query = query.Where(d => d.DueDate >= startDate.Value);
            }

            if (endDate.HasValue)
            {
                query = query.Where(d => d.DueDate <= endDate.Value);
            }

            if (isPaid.HasValue)
            {
                query = query.Where(d => d.Installments.All(i => i.IsPaid == isPaid.Value));
            }

            return await query.ToListAsync();
        }

        public async Task<Installment> RegisterInstallmentPaymentAsync(Guid installmentId, MoneyVO paymentAmount, DateTime paymentDate)
        {
            if (installmentId == Guid.Empty)
            {
                throw new ArgumentException("ID da parcela inválido.", nameof(installmentId));
            }

            var installment = await _context.Installments.FirstOrDefaultAsync(i => i.Id == installmentId);
            if (installment == null)
            {
                throw new KeyNotFoundException($"Parcela com ID {installmentId} não encontrada.");
            }

            installment.AddPayment(paymentAmount);

            _context.Entry(installment).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return installment;
        }

        public async Task<Installment> AddInstallmentToDebtAsync(Guid debtId, Installment installment)
        {
            if (debtId == Guid.Empty)
            {
                throw new ArgumentException("ID da dívida inválido.", nameof(debtId));
            }

            if (installment == null)
            {
                throw new ArgumentNullException(nameof(installment));
            }

            var debt = await _context.Debts.FirstOrDefaultAsync(d => d.Id == debtId);
            if (debt == null)
            {
                throw new KeyNotFoundException($"Dívida com ID {debtId} não encontrada.");
            }

            debt.AddInstallment(installment);

            _context.Entry(debt).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return installment;
        }

        public async Task<bool> IsDebtFullyPaidAsync(Guid debtId)
        {
            if (debtId == Guid.Empty)
            {
                throw new ArgumentException("ID da dívida inválido.", nameof(debtId));
            }

            var debt = await _context.Debts
                                     .Include(d => d.Installments)
                                     .FirstOrDefaultAsync(d => d.Id == debtId);

            if (debt == null)
            {
                throw new KeyNotFoundException($"Dívida com ID {debtId} não encontrada.");
            }

            return debt.IsFullyPaid();
        }
    }
}