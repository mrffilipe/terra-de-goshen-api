namespace TerraDeGoshenAPI.src.Application
{
    public record ColorCreateDTO
    {
        public string Value { get; init; } = string.Empty;
        public Guid? ImageId { get; init; } = Guid.Empty;

        public ColorCreateDTO()
        { }

        public ColorCreateDTO(string value, Guid? imageId)
        {
            Value = value;
            ImageId = imageId;
        }
    }
}