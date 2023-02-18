using AutoMapper;
using ClinicManagement.Contracts;
using ClinicManagement.Data.Dto.Payment;
using ClinicManagement.Data.Dto.Prescription;
using ClinicManagement.Data.Dto.Staff;
using ClinicManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrescriptionController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPrescriptionRepository _prescriptionRepository;

        public PrescriptionController(IMapper mapper,IPrescriptionRepository prescriptionRepository)
        {
            _mapper = mapper;
            _prescriptionRepository = prescriptionRepository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetPrescriptions()
        {
            var prescriptions = _mapper.Map<List<PrescriptionDto>>(await _prescriptionRepository.GetAllAsync());

            return Ok(prescriptions);
        }

        [HttpGet("prescriptionId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PrescriptionDto>> GetPrescription([FromQuery] int prescriptionId)
        {
            if (!await _prescriptionRepository.Exists(prescriptionId))
            {
                return NotFound();
            }

            var prescription = await _prescriptionRepository.GetAsync(prescriptionId);

            if (prescription == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PaymentDto>(prescription));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreatePrescription([FromBody] CreatePaymentDto createPaymentDto)
        {
            if (createPaymentDto == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var prescription = await _prescriptionRepository.AddAsync(_mapper.Map<Prescription>(createPaymentDto));
            return Ok(prescription);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdatePrescription(int prescriptionId, [FromBody] BasePrescriptionDto basePrescriptionDto)
        {
            if (basePrescriptionDto == null)
            {
                return BadRequest(ModelState);
            }
            if (!await _prescriptionRepository.Exists(prescriptionId))
            {
                return NotFound();
            }
            var prescription = await _prescriptionRepository.GetAsync(prescriptionId);
            if (prescription == null)
            {
                return NotFound();
            }
            await _prescriptionRepository.UpdateAsync(_mapper.Map(basePrescriptionDto, prescription));

            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeletePrescription(int prescriptionId)
        {

            if (!await _prescriptionRepository.Exists(prescriptionId))
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _prescriptionRepository.DeleteAsync(prescriptionId);

            return NoContent();
        }
    }

}
