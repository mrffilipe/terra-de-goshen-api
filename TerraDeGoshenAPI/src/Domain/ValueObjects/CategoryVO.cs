namespace TerraDeGoshenAPI.src.Domain
{
    public record CategoryVO
    {
        public string Name { get; } = string.Empty;

        public CategoryVO()
        { }

        public CategoryVO(string name)
        {
            Name = name;
        }
    }
}