namespace TerraDeGoshenAPI.src.Application
{
    public record ImageCreateDTO(IFormFile File, bool IsCover)
    {
        public IFormFile File { get; init; } = File;
        public bool IsCover { get; init; } = IsCover;
    }
}