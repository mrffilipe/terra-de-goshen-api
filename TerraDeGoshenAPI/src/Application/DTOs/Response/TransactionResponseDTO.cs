using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public record TransactionResponseDTO(
        Guid Id,
        decimal Amount,
        TransactionType TransactionType,
        PaymentMethod PaymentMethod,
        ProductResponseDTO? Product,
        CustomerResponseDTO? Customer,
        DateTime CreatedAt,
        DateTime UpdatedAt) : IBaseEntityDTO
    {
        public Guid Id { get; init; } = Id;
        public decimal Amount { get; init; } = Amount;
        public TransactionType TransactionType { get; init; } = TransactionType;
        public PaymentMethod PaymentMethod { get; init; } = PaymentMethod;
        public ProductResponseDTO? Product { get; init; } = Product;
        public CustomerResponseDTO? Customer { get; init; } = Customer;
        public DateTime CreatedAt { get; init; } = CreatedAt;
        public DateTime UpdatedAt { get; init; } = UpdatedAt;
    }
}