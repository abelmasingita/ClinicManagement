using AutoMapper;
using ClinicManagement.Contracts;
using ClinicManagement.Data.Dto.Doctor;
using ClinicManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace ClinicManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
//[Authorize]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IMapper _mapper;

        public DoctorController(IDoctorRepository doctorRepository, IMapper mapper)
        {
            _doctorRepository = doctorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetDoctors()
        {
            var doctors = _mapper.Map<List<GetDoctorDto>>(await _doctorRepository.GetAllAsync());

            return Ok(doctors);
        }

        [HttpGet("doctorId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<GetDoctorDto>> GetDoctor([FromQuery] int doctorId)
        {
            if (!await _doctorRepository.Exists(doctorId))
            {
                return NotFound();
            }

            var doctor = await _doctorRepository.GetAsync(doctorId);

            if (doctor == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<GetDoctorDto>(doctor));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreateDoctor([FromBody] CreateDoctorDto createDoctorDto)
        {
            if (createDoctorDto == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var doctor = await _doctorRepository.AddAsync(_mapper.Map<Doctor>(createDoctorDto));
            return Ok(doctor);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateDoctor(int doctorId, [FromBody] BaseDoctorDto updateDoctorDto)
        {
            if (updateDoctorDto == null)
            {
                return BadRequest(ModelState);
            }
            if (!await _doctorRepository.Exists(doctorId))
            {
                return NotFound();
            }
            var doctor = await _doctorRepository.GetAsync(doctorId);
            if (doctor == null)
            {
                return NotFound();
            }
            await _doctorRepository.UpdateAsync(_mapper.Map(updateDoctorDto, doctor));

            return NoContent();
        }


        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteDoctor(int doctorId)
        {
  
            if (!await _doctorRepository.Exists(doctorId))
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _doctorRepository.DeleteAsync(doctorId);

            return NoContent();
        }
    }
}
