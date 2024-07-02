using AutoMapper;
using DataAccess.Models;
using BusinessLogic;

namespace DataAccess
{
    public class MappingProfile: Profile
    {
        public MappingProfile() {
            CreateMap<Product, ProductObject>();
            CreateMap<Member, MemberObject>();
            CreateMap<Order, OrderObject>();
            CreateMap<OrderDetail, OrderDetailObject>();
        }
    }
}
