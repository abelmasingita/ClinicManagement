using AutoMapper;
using ClinicManagement.Contracts;
using ClinicManagement.Data.Dto.Doctor;
using ClinicManagement.Data.Dto.Patient;
using ClinicManagement.Models;
using ClinicManagement.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IMapper _mapper;

        public PatientController(IPatientRepository patientRepository, IMapper mapper)
        {
            _patientRepository = patientRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetPatients()
        {
            var patients = _mapper.Map<List<PatientDto>>(await _patientRepository.GetAllAsync());

            return Ok(patients);
        }

        [HttpGet("patientId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PatientDto>> GetPatient([FromQuery] int patientId)
        {
            if (!await _patientRepository.Exists(patientId))
            {
                return NotFound();
            }

            var doctor = await _patientRepository.GetAsync(patientId);

            if (doctor == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PatientDto>(doctor));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreatePatient([FromBody] CreatePatientDto createPatientDto)
        {
            if (createPatientDto == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var patient = await _patientRepository.AddAsync(_mapper.Map<Patient>(createPatientDto));
            return Ok(patient);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdatePatient(int patientId, [FromBody] BasePatientDto updatePatientDto)
        {
            if (updatePatientDto == null)
            {
                return BadRequest(ModelState);
            }
            if (!await _patientRepository.Exists(patientId))
            {
                return NotFound();
            }
            var patient = await _patientRepository.GetAsync(patientId);
            if (patient == null)
            {
                return NotFound();
            }
            await _patientRepository.UpdateAsync(_mapper.Map(updatePatientDto, patient));

            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeletePatient(int patientId)
        {

            if (!await _patientRepository.Exists(patientId))
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _patientRepository.DeleteAsync(patientId);

            return NoContent();
        }
    }
}
