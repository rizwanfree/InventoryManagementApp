using RSDBCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.SellService
{
    public class SellInvoiceDetailRepo : ICRUD
    {
        readonly DBSQLite db = new DBSQLite();
        public void DeleteRecord(int rowID)
        {
            string sql = @"DELETE FROM SellInvoiceDetail
                           WHERE SellInvoiceID = @SellInvoiceID";
            db.DeleteRecord(sql, new DBParameter { Parameter = "@SellInvoiceID", Value = rowID });
        }

        public DataTable GetAll()
        {
            throw new NotImplementedException();
        }

        public DataTable GetByID(int id)
        {
            string sql = @"SELECT s.SellInvoiceDetailID,
                           s.SellInvoiceID,
                           s.ProductID,
                           s.Foot,
                           s.Quantity,
                           s.Rate,
                           s.Total,
                           c.CategoryName || ' ' || p.ProductName AS 'ProductName'
                      FROM SellInvoiceDetail s
                      INNER JOIN Products p ON p.ProductID = s.ProductID
                      INNER JOIN Categories c ON c.CategoryID = p.CategoryID
                      WHERE SellInvoiceID = @SellInvoiceID";
            return db.GetDataList(sql, new DBParameter { Parameter = "@SellInvoiceID", Value = id });
        }

        public DataTable GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public DataTable GetForComboBox()
        {
            throw new NotImplementedException();
        }

        public DataRow GetSingle(int ID)
        {  throw new NotImplementedException(); }
        


        public void InsertRecord(object obj)
        {
            string sql = @"INSERT INTO SellInvoiceDetail (                                    
                                      ProductID,
                                      SellInvoiceID,
                                      Foot,
                                      Quantity,
                                      Rate,
                                      Total
                                  )
                                  VALUES (                                     
                                      @ProductID,
                                      @SellInvoiceID,
                                      @Foot,
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
