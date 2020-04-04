using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CC.Models
{
    public class User : IdentityUser
    {
        public override string Id { get; set; }
        public override string Email { get; set; }
        public string Username { get; set; }
        //public string Password { get; set; }

        //[Display(Name = "Date of Birth")]
        //[DataType(DataType.Date)]
        //public DateTime BirthDate { get; set; }
    }
}
