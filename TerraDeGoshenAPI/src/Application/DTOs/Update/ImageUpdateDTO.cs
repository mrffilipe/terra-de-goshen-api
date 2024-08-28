namespace TerraDeGoshenAPI.src.Application
{
    public record ImageUpdateDTO
    {
        public Guid Id { get; init; } = Guid.Empty;
        public IFormFile File { get; init; } = null!;
        public bool IsCover { get; init; } = false;
        public bool IsDeleted { get; init; } = false;

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