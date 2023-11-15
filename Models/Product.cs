using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Models
{
    public class Product
    {
        [Key]
        public int ProdId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Engines { get; set; }
        public string Model { get; set; }
        public double Qty { get; set; }
        public double Price { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        //public string ProStatus= eum
        //public string category= eum
    }
}
