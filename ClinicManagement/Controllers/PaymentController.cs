using AutoMapper;
using ClinicManagement.Contracts;
using ClinicManagement.Data.Dto.Payment;
using ClinicManagement.Data.Dto.Staff;
using ClinicManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPaymentRepository _paymentRepository;

        public PaymentController(IMapper mapper,IPaymentRepository paymentRepository)
        {
            _mapper = mapper;
            _paymentRepository = paymentRepository;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetPayments()
        {
            var payment = _mapper.Map<List<PaymentDto>>(await _paymentRepository.GetAllAsync());

            return Ok(payment);
        }

        [HttpGet("paymentId")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<PaymentDto>> GetPayment([FromQuery] int paymentId)
        {
            if (!await _paymentRepository.Exists(paymentId))
            {
                return NotFound();
            }

            var payment = await _paymentRepository.GetAsync(paymentId);

            if (payment == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<PaymentDto>(payment));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> CreatePayment([FromBody] CreatePaymentDto createPaymentDto)
        {
            if (createPaymentDto == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var payment = await _paymentRepository.AddAsync(_mapper.Map<Payment>(createPaymentDto));
            return Ok(payment);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdatePayment(int paymentId, [FromBody] BasePaymentDto basePaymentDto)
        {
            if (basePaymentDto == null)
            {
                return BadRequest(ModelState);
            }
            if (!await _paymentRepository.Exists(paymentId))
            {
                return NotFound();
            }
            var payment = await _paymentRepository.GetAsync(paymentId);
            if (payment == null)
            {
                return NotFound();
            }
            await _paymentRepository.UpdateAsync(_mapper.Map(basePaymentDto, payment));

            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeletePayment(int paymentId)
        {

            if (!await _paymentRepository.Exists(paymentId))
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _paymentRepository.DeleteAsync(paymentId);

            return NoContent();
        }
    }


}
