using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtbDomain.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        [MaxLength(500)]
        public string Email { get; set; }
        [Required]
        [MaxLength(255)]
        public string Password { get; set; }
        [MaxLength(250)]
        public string PhotoUrl { get; set; }
        [MaxLength(500)]
        public string RefreshToken { get; set; }


        [Required]
        public bool Active { get; set; }
        //[Required]
        //public DateTime CreationDate { get; set; }
        //[Required]
        //public DateTime UpdateDate { get; set; }
        //[Required]
        //[ForeignKey("CreationUser")]
        //public int CreationUserId { get; set; }
        //[ForeignKey("CreationUserId")]
        //public User CreationUser { get; set; }
        //[Required]
        //[ForeignKey("UpdateUser")]
        //public int UpdateUserId { get; set; }
        //[ForeignKey("UpdateUserId")]
        //public User UpdateUser { get; set; }
    }
}
