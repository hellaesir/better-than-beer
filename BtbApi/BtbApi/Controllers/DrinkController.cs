using BtbApi.Controllers.Base;
using BtbService.Interfaces;
using BtbService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BtbApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinkController : BaseController
    {
        private readonly IDrinkService _drinkService;

        public DrinkController(IConfiguration configuration, IDrinkService drinkService, IActiveUserService activeUserService) : base(configuration, activeUserService)
        {

            _drinkService = drinkService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute] int id)
        {
            return Ok(await _drinkService.GetById(id));
        }
    }
}
