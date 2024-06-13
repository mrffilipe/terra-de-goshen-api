namespace TerraDeGoshenAPI.src.Application
{
    public record ColorCreateDTO
    {
        public string Value { get; } = string.Empty;
        public Guid? ImageId { get; } = Guid.Empty;

        public ColorCreateDTO()
        { }

        public ColorCreateDTO(string value, Guid? imageId)
        {
            Value = value;
            ImageId = imageId;
        }
    }
}