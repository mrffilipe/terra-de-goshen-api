namespace TerraDeGoshenAPI.src.Application
{
    public record ImageUpdateDTO
    {
        public Guid Id { get; } = Guid.Empty;
        public IFormFile File { get; } = null!;
        public bool IsCover { get; } = false;
        public bool IsDeleted { get; } = false;

        public ImageUpdateDTO()
        { }

        public ImageUpdateDTO(IFormFile file, bool isCover, bool isDeleted)
        {
            File = file;
            IsCover = isCover;
            IsDeleted = isDeleted;
        }

        public ImageUpdateDTO(Guid id, IFormFile file, bool isCover, bool isDeleted)
            : this(file, isCover, isDeleted)
        {
            Id = id;
        }
    }
}