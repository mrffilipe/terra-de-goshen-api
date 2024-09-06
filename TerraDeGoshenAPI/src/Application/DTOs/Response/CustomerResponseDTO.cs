﻿namespace TerraDeGoshenAPI.src.Application
{
    public record CustomerResponseDTO(
        Guid Id,
        string FirstName,
        string LastName,
        DateTime CreatedAt,
        DateTime UpdatedAt
    ) : IEntityDTO
    {
        public Guid Id { get; init; } = Id;
        public string FirstName { get; init; } = FirstName;
        public string LastName { get; init; } = LastName;
        public DateTime CreatedAt { get; init; } = CreatedAt;
        public DateTime UpdatedAt { get; init; } = UpdatedAt;
    }
}