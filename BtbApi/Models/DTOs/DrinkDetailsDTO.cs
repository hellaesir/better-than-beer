using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbDomain.DTOs
{
    public class DrinkDetailsDTO : DrinkDTO
    {
        public List<IngredientMeasureDTO> IngredientsMeasures { get; set; }
        public List<StepDTO> Steps { get; set; }
    }
}
