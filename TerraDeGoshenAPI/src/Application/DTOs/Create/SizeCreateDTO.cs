namespace TerraDeGoshenAPI.src.Application
{
    public record SizeCreateDTO
    {
        public string Value { get; init; } = string.Empty;

        public SizeCreateDTO()
        { }

        public SizeCreateDTO(string value)
        {
            Value = value;
        }
    }
}