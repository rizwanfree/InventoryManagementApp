using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Entities
{
    public class PurchaseInvoice
    {
        public int PurchaseInvoiceID { get; set; }
        public string InvoiceDate { get; set; }
        public string BillNumber { get; set; }
        public int VendorID { get; set; }
    }
}
