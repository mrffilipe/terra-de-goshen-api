namespace TerraDeGoshenAPI.src.Application
{
    public record InstallmentResponseDTO(
        Guid Id,
        decimal Amount,
        DateTime DueDate,
        decimal AmountPaid,
        bool IsPaid,
        DebtResponseDTO Debt,
        DateTime CreatedAt,
        DateTime UpdatedAt
    ) : IEntityDTO
    {
        public Guid Id { get; init; } = Id;
        public decimal Amount { get; init; } = Amount;
        public DateTime DueDate { get; init; } = DueDate;
        public decimal AmountPaid { get; init; } = AmountPaid;
        public bool IsPaid { get; init; } = IsPaid;
        public DebtResponseDTO Debt { get; init; } = Debt;
        public DateTime CreatedAt { get; init; } = CreatedAt;
        public DateTime UpdatedAt { get; init; } = UpdatedAt;
    }
}