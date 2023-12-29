using RSDBCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.PurchaseService
{
    public class PurchaseInvoiceDetailRepo : ICRUD
    {
        readonly DBSQLite db = new DBSQLite();
        public void DeleteRecord(int rowID)
        {
            string sql = @"DELETE FROM PurchaseInvoiceDetail
                           WHERE PurchaseInvoiceID = @PurchaseInvoiceID";
            db.DeleteRecord(sql, new DBParameter { Parameter = "@PurchaseInvoiceID", Value = rowID });
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

        public DataTable GetByID(int id)
        {
            string sql = @"SELECT s.PurchaseInvoiceDetailID,
                           s.PurchaseInvoiceID,
                           s.ProductID,                           
                           s.Quantity,
                           s.Rate,
                           s.Total,
                           c.CategoryName || ' ' || p.ProductName AS 'ProductName'
                      FROM PurchaseInvoiceDetail s
                      INNER JOIN Products p ON p.ProductID = s.ProductID
                      INNER JOIN Categories c ON c.CategoryID = p.CategoryID
                      WHERE PurchaseInvoiceID = @PurchaseInvoiceID";
            return db.GetDataList(sql, new DBParameter { Parameter = "@PurchaseInvoiceID", Value = id });
        }

        public void InsertRecord(object obj)
        {
            string sql = @"INSERT INTO PurchaseInvoiceDetail (                                    
                                      ProductID,
                                      PurchaseInvoiceID,
                                      Quantity,
                                      Rate,
                                      Total
                                  )
                                  VALUES (                                     
                                      @ProductID,
                                      @PurchaseInvoiceID,
                                      @Quantity,
                                      @Rate,
                                      @Total
                                  )";
            db.InsertOrUpdateRecord(sql, obj);
        }

        public void UpdateRecord(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
