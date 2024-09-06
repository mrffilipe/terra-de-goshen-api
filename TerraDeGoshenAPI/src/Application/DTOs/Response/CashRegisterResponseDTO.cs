namespace TerraDeGoshenAPI.src.Application
{
    public record CashRegisterResponseDTO(
        Guid Id,
        decimal CurrentBalance,
        DateTime CreatedAt,
        DateTime UpdatedAt
    ) : IEntityDTO
    {
        public Guid Id { get; init; } = Id;
        public decimal CurrentBalance { get; init; } = CurrentBalance;
        public DateTime CreatedAt { get; init; } = CreatedAt;
        public DateTime UpdatedAt { get; init; } = UpdatedAt;
    }
}