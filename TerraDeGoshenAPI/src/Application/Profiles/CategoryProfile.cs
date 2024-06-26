﻿using AutoMapper;
using TerraDeGoshenAPI.src.Domain;

namespace TerraDeGoshenAPI.src.Application
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryCreateDTO, CategoryRef>()
                .ConstructUsing(s => new CategoryRef(
                    new CategoryVO(s.Name)
                    ));

            CreateMap<SimpleCategoryCreateDTO, CategoryRef>()
                .ConstructUsing(s => new CategoryRef(s.Id));

            CreateMap<CategoryRef, CategoryResponseDTO>()
                .ConstructUsing(s => new CategoryResponseDTO(
                    s.Id,
                    s.Details.Name,
                    s.CreatedAt,
                    s.UpdatedAt
                    ));

            CreateMap<CategoryUpdateDTO, CategoryRef>()
                .ConstructUsing(s => new CategoryRef(s.Id));
        }
    }
}