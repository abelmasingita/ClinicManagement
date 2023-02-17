using AutoMapper;
using ClinicManagement.Data.Dto.User;
using ClinicManagement.Models;

namespace ClinicManagement.Configurations
{
    public class MappingProfiles : Profile
    {

        public MappingProfiles()
        {
            CreateMap<ApplicationUser, RegisterDto>().ReverseMap();
        }

    }
}
