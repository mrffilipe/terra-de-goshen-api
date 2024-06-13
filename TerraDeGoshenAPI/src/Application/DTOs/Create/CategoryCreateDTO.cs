namespace TerraDeGoshenAPI.src.Application
{
    public record CategoryCreateDTO
    {
        public string Name { get; } = string.Empty;

        public CategoryCreateDTO()
        { }

        public CategoryCreateDTO(string name)
        {
            Name = name;
        }
    }
}