﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC.Models
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }

        public IList<string> Roles { get; set; }
    }
}
