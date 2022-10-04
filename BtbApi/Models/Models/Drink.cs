using BtbDomain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Drink
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(1000)]
        public string Description { get; set; }
        [Required, MaxLength(500)]
        public string MainImageUrl { get; set; }
        [Required, MaxLength (2)]
        public uint GentleOrBoozy { get; set; }
        [Required, MaxLength(2)]
        public uint SweetOrDrySour { get; set; }
        public List<IngredientMeasure> IngredientsMeasures { get; set; }
        public List<RecipeStep> Steps { get; set; }
    }
}
