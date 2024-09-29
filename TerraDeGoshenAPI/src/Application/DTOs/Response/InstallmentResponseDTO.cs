namespace TerraDeGoshenAPI.src.Application
{
    public record InstallmentResponseDTO(
        Guid Id,
        decimal Amount,
        DateTime DueDate,
        decimal AmountPaid,
        bool IsPaid,
        DateTime CreatedAt,
        DateTime UpdatedAt) : IEntityDTO
    {
        public Guid Id { get; } = Id;
        public decimal Amount { get; } = Amount;
        public DateTime DueDate { get; } = DueDate;
        public decimal AmountPaid { get; } = AmountPaid;
        public bool IsPaid { get; } = IsPaid;
        public DateTime CreatedAt { get; } = CreatedAt;
        public DateTime UpdatedAt { get; } = UpdatedAt;
    }
}