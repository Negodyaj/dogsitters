using AutoMapper;

namespace DogSitters.API.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Business.Models.OrderModel, Models.OrderOutputModel>();
        }
    }
}
