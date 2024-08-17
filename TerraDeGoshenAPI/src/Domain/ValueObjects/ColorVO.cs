namespace TerraDeGoshenAPI.src.Domain
{
    public record ColorVO
    {
        public string Value { get; }

        public ColorVO(string value)
        {
            Value = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}