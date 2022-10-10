using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbDomain.Models
{
    public class IngredientMeasure
    {
        [Key]
        public int Id { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }


        public Measure Measure { get; set; }
        public int MeasureId { get; set; }



        [Required]
        public bool Active { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        [Required]
        public DateTime UpdateDate { get; set; }
        [Required]
        public int CreationUserId { get; set; }
        public User CreationUser { get; set; }
        [Required]
        public int UpdateUserId { get; set; }
        public User UpdateUser { get; set; }
    }
}
