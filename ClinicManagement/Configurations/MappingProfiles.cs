using AutoMapper;
using ClinicManagement.Data.Dto.Doctor;
using ClinicManagement.Data.Dto.User;
using ClinicManagement.Models;

namespace ClinicManagement.Configurations
{
    public class MappingProfiles : Profile
    {

        public MappingProfiles()
        {
            CreateMap<ApplicationUser, RegisterDto>().ReverseMap();

            CreateMap<Doctor, GetDoctorDto>().ReverseMap();
            CreateMap<Doctor, BaseDoctorDto>().ReverseMap();
            CreateMap<Doctor, CreateDoctorDto>().ReverseMap(); 
        }

    }
}
