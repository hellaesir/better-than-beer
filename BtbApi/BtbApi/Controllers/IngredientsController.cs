using BtbDomain.DTOs;
using BtbDomain.DTOs.Creates;
using BtbService.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BtbApi.Controllers
{
    [Route("api/ingredients")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly ILogger<IngredientsController> _logger;
        private readonly IIngredientService _ingredientService;

        public IngredientsController(ILogger<IngredientsController> logger, IIngredientService? ingredientService)
        {
            _logger = logger;
            _ingredientService = ingredientService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute] int id)
        {
            return Ok(await _ingredientService.GetById(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] int pageIndex, [FromQuery]int pageSize)
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
