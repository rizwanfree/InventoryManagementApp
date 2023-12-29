using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Entities
{
    public class SellInvoiceDetail
    {
        public int SellInvoiceDetailID { get; set; }
        public int SellInvoiceID { get; set; }
        public int ProductID { get; set; }
        public decimal Foot { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Total { get; set; }
    }
}
