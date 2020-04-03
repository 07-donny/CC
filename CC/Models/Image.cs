using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public string Caption { get; set; }

        public byte[] Img { get; set; }
    }
}
