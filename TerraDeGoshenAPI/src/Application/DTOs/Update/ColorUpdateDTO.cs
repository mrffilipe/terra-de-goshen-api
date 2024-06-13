namespace TerraDeGoshenAPI.src.Application
{
    public record ColorUpdateDTO
    {
        public Guid Id { get; } = Guid.Empty;
        public string Value { get; } = string.Empty;
        public Guid? ImageId { get; } = Guid.Empty;
        public bool IsDeleted { get; } = false;

        public ColorUpdateDTO()
        { }

        public ColorUpdateDTO(Guid id, string value, Guid? imageId, bool isDeleted)
        {
            Id = id;
            Value = value;
            ImageId = imageId;
            IsDeleted = isDeleted;
        }
    }
}