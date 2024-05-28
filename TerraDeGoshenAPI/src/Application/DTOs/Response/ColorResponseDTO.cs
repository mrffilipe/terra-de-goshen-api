namespace TerraDeGoshenAPI.src.Application
{
    public record ColorResponseDTO(
        Guid Id,
        string Value,
        Guid? ImageId,
        DateTime CreatedAt,
        DateTime UpdatedAt
        );
}