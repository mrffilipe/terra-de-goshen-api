namespace TerraDeGoshenAPI.src.Domain
{
    public interface ICashRegisterService
    {
        Task AddTransactionAsync(Guid cashRegisterId, Transaction transaction);
        Task<MoneyVO> GetCurrentBalanceAsync(Guid cashRegisterId);
    }
}