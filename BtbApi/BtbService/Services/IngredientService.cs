using AutoMapper;
using BtbDomain.Bases;
using BtbDomain.DTOs;
using BtbDomain.DTOs.Creates;
using BtbDomain.Models;
using BtbRepository.Interfaces;
using BtbRepository.Repositories;
using BtbService.Bases;
using BtbService.Interfaces;
using Domain.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbService.Services
{
    public class IngredientService : BaseService, IIngredientService
    {
        private readonly IMapper _mapper;
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientService(IMapper mapper, IConfiguration configuration, IActiveUserService activeUserService, IIngredientRepository ingredientRepository) : base(configuration, activeUserService)
        {
            _mapper = mapper;
            _ingredientRepository = ingredientRepository;
        }

        public async Task Create(IngredientCreateDTO entity)
        {
            Ingredient ingredient = _mapper.Map<Ingredient>(entity);
            await _ingredientRepository.Create(ingredient, ActiveUser);
        }

        public async Task<IngredientDTO> GetById(int id)
        {
            var ingredient = await _ingredientRepository.GetById(id);
            var ret = _mapper.Map<IngredientDTO>(ingredient);
            return ret;
        }

        public async Task<BaseListResponse<IngredientDTO>> GetList(int pageIndex, int pageSize)
        {
            var ingredients = await _ingredientRepository.GetList(pageIndex, pageSize);

            var result = new BaseListResponse<IngredientDTO>()
            {
                Items = _mapper.Map<List<IngredientDTO>>(ingredients),
                Total = await _ingredientRepository.Count(),
                PageSize = pageSize,
                Page = pageIndex
            };

            return result;
        }

        public async Task Update(IngredientUpdateDTO entity)
        {
            await _ingredientRepository.Update(_mapper.Map<Ingredient>(entity), ActiveUser);
        }
    }
}
