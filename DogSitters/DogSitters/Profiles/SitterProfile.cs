using AutoMapper;

namespace DogSitters.API.Profiles
{
    public class SitterProfile : Profile
    {
        public SitterProfile()
        {
            CreateMap<Business.Models.SitterModel, Models.SitterOutputModel>();
            CreateMap<Models.SitterInsertInputModel, Business.Models.SitterModel>();
            CreateMap<Models.SitterUpdateInputModel, Business.Models.SitterModel>();
        }
    }
}
