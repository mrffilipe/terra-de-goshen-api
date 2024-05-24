using Microsoft.AspNetCore.Http;

namespace TerraDeGoshenAPI.Application
{
    public record ImageCreateDTO(
        IFormFile File,
        bool IsCover = false
        );
}