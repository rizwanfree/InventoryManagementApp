using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Entities
{
    public class VendorLedger
    {
        public int TransactionID { get; set; }
        public DateTime TransactionDate { get; set; }
        public int VendorID { get; set; }
        public string Particular { get; set; } = string.Empty;
        public int Debit { get; set; }
        public int Credit { get; set; }
        public string Reff { get; set; } = string.Empty;
        public string DRCR { get; set; } = string.Empty;
    }
}
