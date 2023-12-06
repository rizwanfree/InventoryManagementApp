using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Entities
{
    public class CustomerLedger
    {
        public int TransactionID { get; set; }
        public string TransactionDate { get; set; }
        public int CustomerID { get; set; }
        public string Particular { get; set; } = string.Empty;
        public int Debit { get; set; }
        public int Credit { get; set; }
        public string Reff { get; set; } = string.Empty;
        public string DRCR { get; set; } = string.Empty;
    }
}
