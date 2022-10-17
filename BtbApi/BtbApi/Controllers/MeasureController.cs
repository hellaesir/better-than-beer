using BtbApi.Controllers.Base;
using BtbDomain.DTOs;
using BtbDomain.DTOs.Creates;
using BtbService.Interfaces;
using BtbService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BtbApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasureController : BaseController
    {
        private readonly IMeasureService _measureService;

        public MeasureController(IConfiguration configuration, IActiveUserService activeUserService, IMeasureService measureService) : base(configuration, activeUserService)
        {
            _measureService = measureService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute] int id)
        {
            return Ok(await _measureService.GetById(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] int pageIndex, [FromQuery] int pageSize)
        {
            return Ok(await _measureService.GetList(pageIndex, pageSize));
        }

        [HttpPost]
        public async Task<IActionResult> GetList([FromBody] MeasureCreateDTO measure)
        {
            await _measureService.Create(measure);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] MeasureUpdateDTO measure)
        {
            await _measureService.Update(measure);
            return Ok();
        }
    }
}
