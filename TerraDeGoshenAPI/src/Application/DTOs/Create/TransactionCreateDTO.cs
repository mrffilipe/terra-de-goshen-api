using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public record TransactionCreateDTO(
        decimal Amount,
        TransactionType TransactionType,
        PaymentMethod PaymentMethod,
        Guid? ProductId,
        Guid? CustomerId)
    {
        public decimal Amount { get; init; } = Amount;
        public TransactionType TransactionType { get; init; } = TransactionType;
        public PaymentMethod PaymentMethod { get; init; } = PaymentMethod;
        public Guid? ProductId { get; init; } = ProductId;
        public Guid? CustomerId { get; init; } = CustomerId;
    }
}