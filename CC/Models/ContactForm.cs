using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CC.Models
{
    public class ContactForm
    {
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]

        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public int Phone { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
