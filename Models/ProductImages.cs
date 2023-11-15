using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Models
{
    public class ProductImages
    {
        [Key]
        public int ProdImgId { get; set; }
        public int ProdId { get; set; }
        [ForeignKey("ProdId")]
        public Product Product { get; set; }
        public string ImgUrl { get; set; }
    }
}
