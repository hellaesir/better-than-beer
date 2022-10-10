using BtbApi.Controllers.Base;
using BtbDomain.DTOs;
using BtbDomain.DTOs.Creates;
using BtbService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BtbApi.Controllers
{
    [Route("api/ingredients")]
    [ApiController]
    public class IngredientsController : BaseController
    {
        private readonly IIngredientService _ingredientService;

        public IngredientsController(IConfiguration configuration, IIngredientService? ingredientService, IActiveUserService activeUserService) : base(configuration, activeUserService)
        {

            _ingredientService = ingredientService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute] int id)
        {
            return Ok(await _ingredientService.GetById(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] int pageIndex, [FromQuery] int pageSize)
        {
            return Ok(await _ingredientService.GetList(pageIndex, pageSize));
        }

        [HttpPost]
        public async Task<IActionResult> GetList([FromBody] IngredientCreateDTO ingredient)
        {
            await _ingredientService.Create(ingredient);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] IngredientUpdateDTO ingredient)
        {
            await _ingredientService.Update(ingredient);
            return Ok();
        }
    }
}
