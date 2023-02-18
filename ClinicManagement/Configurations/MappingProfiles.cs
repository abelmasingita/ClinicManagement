using AutoMapper;
using ClinicManagement.Data.Dto.Doctor;
using ClinicManagement.Data.Dto.Patient;
using ClinicManagement.Data.Dto.Staff;
using ClinicManagement.Data.Dto.User;
using ClinicManagement.Models;

namespace ClinicManagement.Configurations
{
    public class MappingProfiles : Profile
    {

        public MappingProfiles()
        {
            CreateMap<ApplicationUser, RegisterDto>().ReverseMap();
            CreateMap<Doctor, DoctorDto>().ReverseMap();
            CreateMap<Doctor, BaseDoctorDto>().ReverseMap();
            CreateMap<Doctor, CreateDoctorDto>().ReverseMap();
            CreateMap<Patient, PatientDto>().ReverseMap();
            CreateMap<Patient, BasePatientDto>().ReverseMap();
            CreateMap<Patient, CreatePatientDto>().ReverseMap();
            CreateMap<Staff, StaffDto>().ReverseMap();
            CreateMap<Staff, BaseStaffDto>().ReverseMap();
            CreateMap<Staff, CreateStaffDto>().ReverseMap();
        }

    }
}
