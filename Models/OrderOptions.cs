using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class OrderOptions
    {
        [Key]
        public int OrderOptionId { get; set; }
        public int OrderDetailId { get; set; }
        [ForeignKey("OrderDetailId")]
        public OrderDetails OrderDetails { get; set; }
        public int OptionId { get; set; }
        [ForeignKey("OptionId")]
        public CustomizationOpt CustomizationOpt { get; set; }
       
    }
}
