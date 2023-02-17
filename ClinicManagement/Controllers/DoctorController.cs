using AutoMapper;
using ClinicManagement.Contracts;
using ClinicManagement.Data.Dto.Doctor;
using Microsoft.AspNetCore.Mvc;



namespace ClinicManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IMapper _mapper;

        public DoctorController(IDoctorRepository doctorRepository,IMapper mapper)
        {
            _doctorRepository = doctorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDoctors()
        {
            var doctors =  _mapper.Map<List<GetDoctorDto>>( await _doctorRepository.GetAllAsync());

            return Ok(doctors);
        }

    }
}
