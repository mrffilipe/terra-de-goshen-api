namespace TerraDeGoshenAPI.src.Application
{
    public record ColorUpdateDTO
    {
        public Guid Id { get; } = Guid.Empty;
        public Guid? ImageId { get; } = Guid.Empty;
        public bool IsDeleted { get; } = false;

        public ColorUpdateDTO()
        { }

        public ColorUpdateDTO(Guid id, Guid? imageId, bool isDeleted)
        {
            Id = id;
            ImageId = imageId;
            IsDeleted = isDeleted;
        }
    }
}