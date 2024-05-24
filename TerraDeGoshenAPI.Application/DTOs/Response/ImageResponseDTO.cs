namespace TerraDeGoshenAPI.Application
{
    public record ImageResponseDTO(
        Guid Id,
        string Url,
        DateTime CreatedAt,
        DateTime UpdatedAt
        );
}