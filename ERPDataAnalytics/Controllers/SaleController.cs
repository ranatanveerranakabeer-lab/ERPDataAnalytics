using ERPDataAnalytics.Application.cs.DTO.Sale;
using ERPDataAnalytics.Application.cs.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ERPDataAnalytics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISaleService _service;

        public SaleController(ISaleService service)
        {
            _service = service;
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(SaleCreateDTO dto)
        {
            var result = await _service.CreateSaleAsync(dto);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(SaleUpdateDTO dto)
        {
            var result = await _service.UpdateSaleAsync(dto);
            if (!result.Success) return BadRequest(result);
            return Ok(result);
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);
            if (!result.Success) return NotFound(result);
            return Ok(result);
        }

        [HttpGet("report")]
        public async Task<IActionResult> GetReport()
        {
            var result = await _service.GetSaleReportAsync();
            return Ok(result);
        }

        [HttpGet("report/date")]
        public async Task<IActionResult> GetReportByDate([FromQuery] DateTime fromDate, [FromQuery] DateTime toDate)
        {
            var result = await _service.GetSaleReportByDateAsync(fromDate, toDate);
            return Ok(result);
        }

        [HttpGet("report/customer/{customerId}")]
        public async Task<IActionResult> GetReportByCustomer(int customerId)
        {
            var result = await _service.GetSaleReportByCustomerAsync(customerId);
            return Ok(result);
        }

        [HttpGet("summary")]
        public async Task<IActionResult> GetSummary()
        {
            var result = await _service.GetSaleSummaryAsync();
            return Ok(result);
        }
    }
}