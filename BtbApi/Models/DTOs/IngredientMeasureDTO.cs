using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbDomain.DTOs
{
    public class IngredientMeasureDTO
    {
        public IngredientDTO Ingredient { get; set; }
        public MeasureDTO Measure { get; set; }
    }
}
