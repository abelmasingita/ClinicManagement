using AutoMapper;
using ClinicManagement.Contracts;
using ClinicManagement.Data.Dto.Patient;
using ClinicManagement.Data.Dto.Staff;
using ClinicManagement.Models;
using ClinicManagement.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IStaffRepository _staffRepository;

        public StaffController(IMapper mapper, IStaffRepository staffRepository)
        {
            _mapper = mapper;
            _staffRepository = staffRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetStaffs()
        {
            var staff = _mapper.Map<List<StaffDto>>(await _staffRepository.GetAllAsync());

            return Ok(staff);
        }

        [HttpGet("staffId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<StaffDto>> GetStaff([FromQuery] int staffId)
        {
            if (!await _staffRepository.Exists(staffId))
            {
                return NotFound();
            }

            var staff = await _staffRepository.GetAsync(staffId);

            if (staff == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<StaffDto>(staff));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreateStaff([FromBody] CreateStaffDto createStaffDto)
        {
            if (createStaffDto == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var staff = await _staffRepository.AddAsync(_mapper.Map<Staff>(createStaffDto));
            return Ok(staff);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateStaff(int staffId, [FromBody] BaseStaffDto updateStaffDto)
        {
            if (updateStaffDto == null)
            {
                return BadRequest(ModelState);
            }
            if (!await _staffRepository.Exists(staffId))
            {
                return NotFound();
            }
            var staff = await _staffRepository.GetAsync(staffId);
            if (staff == null)
            {
                return NotFound();
            }
            await _staffRepository.UpdateAsync(_mapper.Map(updateStaffDto, staff));

            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeletePatient(int staffId)
        {

            if (!await _staffRepository.Exists(staffId))
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _staffRepository.DeleteAsync(staffId);

            return NoContent();
        }
    }
}
