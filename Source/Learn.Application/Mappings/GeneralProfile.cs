using AutoMapper;
using Learn.Application.Features.Products.Commands.CreateProduct;
using Learn.Application.Features.Products.Queries.GetAllProducts;
using Learn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
        }
    }
}
