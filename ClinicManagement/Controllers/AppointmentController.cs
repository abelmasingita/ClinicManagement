using AutoMapper;
using ClinicManagement.Contracts;
using ClinicManagement.Data.Dto.Appointment;
using ClinicManagement.Data.Dto.Staff;
using ClinicManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentController(IMapper mapper, IAppointmentRepository appointmentRepository)
        {
            _mapper = mapper;
            _appointmentRepository = appointmentRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAppointments()
        {
            var appointment = _mapper.Map<List<AppointmentDto>>(await _appointmentRepository.GetAllAsync());

            return Ok(appointment);
        }

        [HttpGet("appointmentId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AppointmentDto>> GetAppointment([FromQuery] int appointmentId)
        {
            if (!await _appointmentRepository.Exists(appointmentId))
            {
                return NotFound();
            }

            var appointment = await _appointmentRepository.GetAsync(appointmentId);

            if (appointment == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AppointmentDto>(appointment));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreateAppointment([FromBody] CreateAppointmenDto createAppointmentDto)
        {
            if (createAppointmentDto == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var appointment = await _appointmentRepository.AddAsync(_mapper.Map<Appointment>(createAppointmentDto));
            return Ok(appointment);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateAppointment(int appointmentId, [FromBody] BaseAppointmentDto updateAppointmentDto)
        {
            if (updateAppointmentDto == null)
            {
                return BadRequest(ModelState);
            }
            if (!await _appointmentRepository.Exists(appointmentId))
            {
                return NotFound();
            }
            var appointment = await _appointmentRepository.GetAsync(appointmentId);
            if (appointment == null)
            {
                return NotFound();
            }
            await _appointmentRepository.UpdateAsync(_mapper.Map(updateAppointmentDto, appointment));

            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteAppointment(int appointmentId)
        {

            if (!await _appointmentRepository.Exists(appointmentId))
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _appointmentRepository.DeleteAsync(appointmentId);

            return NoContent();
        }
    }


}
