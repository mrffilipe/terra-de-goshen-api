namespace TerraDeGoshenAPI.src.Domain
{
    public record SizeVO
    {
        public string Value { get; } = string.Empty;

        public SizeVO()
        { }

        public SizeVO(string value)
        {
            Value = value;
        }
    }
}