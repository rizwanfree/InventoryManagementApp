using RSDBCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.SellService
{
    public class SellInvoiceRepo : ICRUD
    {
        DBSQLite db = new DBSQLite();
        public void DeleteRecord(int rowID)
        {
            string sql = @"DELETE FROM SellInvoice
                           WHERE SellInvoiceID = @SellInvoiceID";
            db.DeleteRecord(sql, new DBParameter { Parameter = "@SellInvoiceID", Value = rowID });
        }

        public int GetLastInvoiceID()
        {
            string sql = @"SELECT MAX(SellInvoiceID)
                           FROM SellInvoice";
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
            string sql = @"INSERT INTO SellInvoice (                                
                                InvoiceDate,
                                BillNumber,
                                CustomerID
                            )
                            VALUES (                                
                                @InvoiceDate,
                                @BillNumber,
                                @CustomerID
                            )";
            db.InsertOrUpdateRecord(sql, obj);
        }

        public void UpdateRecord(object obj)
        {
            string sql = @"INSERT INTO SellInvoice (                                
                                InvoiceDate,
                                BillNumber,
                                CustomerID
                            )
                            VALUES (                                
                                @InvoiceDate,
                                @BillNumber,
                                @CustomerID
                            )";
            db.InsertOrUpdateRecord(sql, obj);
        }
    }
}
