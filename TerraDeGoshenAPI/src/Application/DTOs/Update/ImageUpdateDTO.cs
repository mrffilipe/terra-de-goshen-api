namespace TerraDeGoshenAPI.src.Application
{
    public record ImageUpdateDTO
    {
        public Guid Id { get; } = Guid.Empty;
        public string Url { get; } = string.Empty;
        public IFormFile? File { get; }
        public bool IsDeleted { get; } = false;

        public ImageUpdateDTO()
        { }

        public ImageUpdateDTO(Guid id, string url, IFormFile? file, bool isDeleted)
        {
            Id = id;
            Url = url;
            File = file;
            IsDeleted = isDeleted;
        }
    }
}