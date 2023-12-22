using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Entities
{
    public class PurchaseInvoiceDetail
    {
        public int PurchaseInvoiceDetailID { get; set; }
        public int PurchaseInvoiceID { get; set; }
        public int ProductID { get; set; }
        public decimal Quantity { get; set; }
        public decimal Rate { get; set; }
        public decimal Total { get; set; }
    }
}
