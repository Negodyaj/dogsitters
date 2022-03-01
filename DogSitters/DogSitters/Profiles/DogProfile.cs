using AutoMapper;

namespace DogSitters.API.Profiles
{
    public class DogProfile : Profile
    {
        public DogProfile()
        {
            CreateMap<Business.Models.DogModel, Models.DogOutputModel>();
            CreateMap<Models.DogInsertInputModel, Business.Models.DogModel>();
            CreateMap<Models.DogUpdateInputModel, Business.Models.DogModel>();
        }
    }
}
