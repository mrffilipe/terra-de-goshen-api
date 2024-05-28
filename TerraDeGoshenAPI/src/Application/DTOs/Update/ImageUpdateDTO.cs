namespace TerraDeGoshenAPI.src.Application
{
    public record ImageUpdateDTO(
        Guid Id,
        string Url,
        IFormFile? File = null,
        bool IsDeleted = false
        );
}