using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BtbDomain.DTOs
{
    public class UserAuthenticationDTO
    {
        public string CompleteName { get; set; }
        public string FirstName { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
    }
}
