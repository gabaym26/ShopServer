using AutoMapper;
using Shop.Core.Dtos;
using Shop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Shopping, ShoppingDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();

        }
    }
}
