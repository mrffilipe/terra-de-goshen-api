﻿namespace TerraDeGoshenAPI.src.Application
{
    public record ColorUpdateDTO
    {
        public Guid Id { get; init; } = Guid.Empty;
        public Guid? ImageId { get; init; } = Guid.Empty;
        public bool IsDeleted { get; init; } = false;

        public ColorUpdateDTO()
        { }

        public ColorUpdateDTO(Guid id, Guid? imageId, bool isDeleted)
        {
            Id = id;
            ImageId = imageId;
            IsDeleted = isDeleted;
        }
    }
}