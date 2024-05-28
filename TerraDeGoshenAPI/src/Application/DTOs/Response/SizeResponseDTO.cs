namespace TerraDeGoshenAPI.src.Application
{
    public record SizeResponseDTO(
        Guid Id,
        string Value,
        DateTime CreatedAt,
        DateTime UpdatedAt
        );
}