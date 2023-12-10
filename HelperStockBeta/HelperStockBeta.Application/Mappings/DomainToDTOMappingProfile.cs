using AutoMapper;
using HelperStockBeta.Application.DTOs;
using HelperStockBeta.Application.Interface;
using HelperStockBeta.Domain.Entities;
using HelperStockBeta.Application.services;

namespace HelperStockBeta.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
      public DomainToDTOMappingProfile() 
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
           


        }

    }
}
