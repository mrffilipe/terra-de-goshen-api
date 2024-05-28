namespace TerraDeGoshenAPI.src.Application
{
    public record ImageCreateDTO(
        IFormFile File,
        bool IsCover = false
        );
}