using RSDBCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.PurchaseService
{
    public class PurchaseInvoiceRepo : ICRUD
    {
        DBSQLite db = new DBSQLite();
        public void DeleteRecord(int rowID)
        {
            string sql = @"DELETE FROM PurchaseInvoice
                           WHERE PurchaseInvoiceID = @PurchaseInvoiceID";
            db.DeleteRecord(sql, new DBParameter { Parameter = "@PurchaseInvoiceID", Value = rowID });
        }

        public int GetLastInvoiceID()
        {
            string sql = @"SELECT MAX(PurchaseInvoiceID)
                           FROM PurchaseInvoice";
            return Convert.ToInt32(db.GetScalarValue(sql));
        }

        public DataTable GetAll()
        {
            throw new NotImplementedException();
        }

        public DataTable GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public DataTable GetForComboBox()
        {
            throw new NotImplementedException();
        }

        public DataRow GetSingle(int rowID)
        {
            throw new NotImplementedException();
        }

        public void InsertRecord(object obj)
        {
            string sql = @"INSERT INTO PurchaseInvoice (
                                
                                InvoiceDate,
                                BillNumber,
                                VendorID
                            )
                            VALUES (                                
                                @InvoiceDate,
                                @BillNumber,
                                @VendorID
                            )";
            db.InsertOrUpdateRecord(sql, obj);
        }

        public void UpdateRecord(object obj)
        {
            string sql = @"INSERT INTO PurchaseInvoice (                                
                                InvoiceDate,
                                BillNumber,
                                VendorID
                            )
                            VALUES (                                
                                @InvoiceDate,
                                @BillNumber,
                                @VendorID
                            )";
            db.InsertOrUpdateRecord(sql, obj);
        }
    }
}
