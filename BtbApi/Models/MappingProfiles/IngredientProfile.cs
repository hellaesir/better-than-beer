using AutoMapper;
using BtbDomain.DTOs;
using BtbDomain.DTOs.Creates;
using BtbDomain.Models;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbDomain.MappingProfiles
{
    public class IngredientProfile : Profile
    {
        public IngredientProfile()
        {
            CreateMap<Ingredient, IngredientDTO>().ReverseMap();
            CreateMap<Ingredient, IngredientUpdateDTO>().ReverseMap();
        }
    }
}
