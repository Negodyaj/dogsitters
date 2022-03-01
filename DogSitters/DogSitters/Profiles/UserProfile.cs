using AutoMapper;

namespace DogSitters.API.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Business.Models.UserModel, Models.UserOutputModel>();
            CreateMap<Models.UserInsertInputModel, Business.Models.UserModel>();
            CreateMap<Models.UserUpdateInputModel, Business.Models.UserModel>();
        }
    }
}
