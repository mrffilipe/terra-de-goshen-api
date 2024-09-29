namespace TerraDeGoshenAPI.src.Application
{
    public record CashRegisterResponseDTO(
        Guid Id,
        decimal CurrentBalance,
        DateTime CreatedAt,
        DateTime UpdatedAt) : IBaseEntityDTO
    {
        public Guid Id { get; } = Id;
        public decimal CurrentBalance { get; } = CurrentBalance;
        public DateTime CreatedAt { get; } = CreatedAt;
        public DateTime UpdatedAt { get; } = UpdatedAt;
    }
}