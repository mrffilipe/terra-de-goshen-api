namespace TerraDeGoshenAPI.Application
{
    public record CategoryResponseDTO(
        Guid Id,
        string Name,
        DateTime CreatedAt,
        DateTime UpdatedAt
        );
}