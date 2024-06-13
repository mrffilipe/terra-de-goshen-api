namespace TerraDeGoshenAPI.src.Domain
{
    public record ColorVO
    {
        public string Value { get; } = string.Empty;

        public ColorVO()
        { }

        public ColorVO(string value)
        {
            Value = value;
        }
    }
}