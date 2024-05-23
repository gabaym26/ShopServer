using AutoMapper;
using Shop.Api.Models;
using Shop.Core.Entities;

namespace Shop.Api.Mapping
{
    public class ApiMappingProfile:Profile
    {
        public ApiMappingProfile()
        {
            CreateMap<CustomerPostModel, Customer>().ReverseMap();
            CreateMap<ProductPostModel, Product>().ReverseMap();
            CreateMap<ShoppingPostModel, Shopping>().ReverseMap();
        }
    }
}
