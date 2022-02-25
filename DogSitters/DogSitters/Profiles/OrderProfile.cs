using AutoMapper;

namespace DogSitters.API.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Business.Models.OrderModel, Models.OrderOutputModel>();
            CreateMap<List<Business.Models.OrderModel>, List<Models.OrderOutputModel>>();
            CreateMap<Models.OrderInsertInputModel, Business.Models.OrderModel>();
            CreateMap<Models.OrderUpdateInputModel, Business.Models.OrderModel>();
        }
    }
}
