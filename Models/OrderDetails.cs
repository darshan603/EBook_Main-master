using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Orders Orders { get; set; }
        public int ProdId { get; set; }
        [ForeignKey("ProdId")]
        public Product Product { get; set; }
        public int Qty { get; set; }
        public double SubTotal { get; set; }

    }
}
