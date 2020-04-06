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
        public override string UserName { get; set; }
    }
}
