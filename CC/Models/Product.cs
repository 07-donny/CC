using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CC.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name="Product Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        //Deze accepteert geen komma en de punt maakt er duizenden van en de oplossing op SO is te ingewikkeld dus FML
        public float Price { get; set; }
        
        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Category { get; set; }

        public string Description { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(20)]
        public string Rarity { get; set; }
        public string ImageFileName { get; set; }

    }
}
