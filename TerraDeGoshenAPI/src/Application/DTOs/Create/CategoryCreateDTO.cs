namespace TerraDeGoshenAPI.src.Application
{
    public record CategoryCreateDTO
    {
        public string Name { get; init; } = string.Empty;

        public CategoryCreateDTO()
        { }

        public CategoryCreateDTO(string name)
        {
            Name = name;
        }
    }
}