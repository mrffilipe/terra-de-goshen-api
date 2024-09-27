namespace TerraDeGoshenAPI.src.Domain
{
    public interface ICashRegisterService
    {
        Task<Transaction> AddTransactionAsync(Transaction transaction);
        Task<CashRegister> GetCashRegisterAsync();
        Task<MoneyVO> GetCurrentBalanceAsync();
        Task<IList<Transaction>> GetTransactionsAsync(DateTime? startDate = null, DateTime? endDate = null);
    }
}