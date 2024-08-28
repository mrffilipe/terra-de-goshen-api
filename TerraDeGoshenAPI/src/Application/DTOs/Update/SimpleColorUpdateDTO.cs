namespace TerraDeGoshenAPI.src.Application
{
    public record SimpleColorUpdateDTO
    {
        public Guid Id { get; init; } = Guid.Empty;
        public Guid? ImageId { get; init; } = Guid.Empty;

        public SimpleColorUpdateDTO()
        { }

        public SimpleColorUpdateDTO(Guid id, Guid? imageId)
        {
            Id = id;
            ImageId = imageId;
        }
    }
}