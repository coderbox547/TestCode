using AutoMapper;
using WebApplication.Contracts.Responses;
using WebApplication.Data;

namespace WebApplication.AutoMapper
{
    public class MapperProfile :Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserResponse>(); 
        }
    }
}
