namespace TerraDeGoshenAPI.src.Application
{
    public record ImageCreateDTO
    {
        public IFormFile File { get; }
        public bool IsCover { get; } = false;

        public ImageCreateDTO()
        { }

        public ImageCreateDTO(IFormFile file, bool isCover)
        {
            File = file;
            IsCover = isCover;
        }
    }
}