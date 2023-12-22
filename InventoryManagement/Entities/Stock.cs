using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Entities
{
    public class Stock
    {
        public int StockID { get; set; }
        public string UpdateDate { get; set; } = string.Empty;
        public int ProductID { get; set; }
        public decimal Rate { get; set; }
        public decimal InStock { get; set; }
    }
}
