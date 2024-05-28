namespace TerraDeGoshenAPI.src.Application
{
    public record ImageResponseDTO(
        Guid Id,
        string Url,
        bool IsCover,
        DateTime CreatedAt,
        DateTime UpdatedAt
        );
}