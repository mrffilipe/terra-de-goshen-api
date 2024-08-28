namespace TerraDeGoshenAPI.src.Domain
{
    public interface ICashRegisterAdapter
    {
        Task AddTransactionAsync(Guid cashRegisterId, Transaction transaction);
        Task<MoneyVO> GetCurrentBalanceAsync(Guid cashRegisterId);
    }
}