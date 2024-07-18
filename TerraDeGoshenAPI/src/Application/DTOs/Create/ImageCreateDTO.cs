namespace TerraDeGoshenAPI.src.Application
{
    public record ImageCreateDTO
    {
        public IFormFile File { get; init; } = null!;
        public bool IsCover { get; init; } = false;

        public ImageCreateDTO()
        { }

        public ImageCreateDTO(IFormFile file, bool isCover)
        {
            File = file;
            IsCover = isCover;
        }
    }
}