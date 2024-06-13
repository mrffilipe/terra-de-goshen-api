namespace TerraDeGoshenAPI.src.Application
{
    public record SimpleColorCreateDTO
    {
        public Guid Id { get; init; } = Guid.Empty;
        public Guid? ImageId { get; init; } = Guid.Empty;

        public SimpleColorCreateDTO()
        { }

        public SimpleColorCreateDTO(Guid id, Guid? imageId)
        {
            Id = id;
            ImageId = imageId;
        }
    }
}