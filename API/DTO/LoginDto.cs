using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTO
{
    public class LoginDto
    {
        public string Username {get; set;} =default!;

        public string Password {get; set;} =default!;
    }
}