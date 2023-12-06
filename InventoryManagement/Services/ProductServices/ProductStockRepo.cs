using RSDBCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.ProductServices
{
    public class ProductStockRepo
    {
        DBSQLite db = new();
        public void DeleteRecord(int rowID)
        {
            string sql = @"DELETE FROM Stock
                           WHERE StockID = @StockID";
            
            db.DeleteRecord(sql, new DBParameter { Parameter = "@StockID", Value = rowID });
        }

        public DataTable GetAll()
        {
            string sql = @"SELECT s.StockID,
                           s.UpdateDate,
                           p.ProductName as 'Product Name',
                           s.InStock
                           FROM Stock s
                           INNER JOIN Products p ON p.ProductID = s.ProductID";
            return db.GetDataList(sql);
        }

        public DataTable GetByName(string name)
        {
            string sql = @"SELECT s.StockID,
                       s.UpdateDate,
                       p.ProductName as 'Product Name',
                       s.InStock
                  FROM Stock s
                  INNER JOIN Products p ON p.ProductID = s.ProductID
                  WHERE p.ProcuctName = @ProductName";
            return db.GetDataList(sql, new DBParameter { Parameter = "@ProductName", Value=name });
        }


        public DataRow GetSingle(int rowID)
        {
            string sql = @"SELECT s.StockID,
                           s.UpdateDate,
                           s.ProductID,
                           p.ProductName as 'Product Name',
                           s.InStock
                           FROM Stock s
                           INNER JOIN Products p ON p.ProductID = s.ProductID
                           WHERE s.ProductID = @ProductID";

            DataTable dt = db.GetDataList(sql, new DBParameter { Parameter = "@ProductID", Value = rowID });
            return dt.Rows[0];
        }

        public void InsertRecord(object obj)
        {
            string sql = @"INSERT INTO Stock (                      
                      UpdateDate,
                      ProductID,
                      Rate,
                      InStock
                  )
                  VALUES (                      
                      @UpdateDate,
                      @ProductID,
                      @Rate,
                      @InStock
                  )";
            db.InsertOrUpdateRecord(sql, obj);
        }

        public void UpdateRecord(object obj)
        {

        }

        public void UpdateStock(object obj)
        {
            string sql = @"UPDATE Stock
                           SET UpdateDate = @UpdateDate,
                               InStock = @InStock'
                           WHERE ProductID = @ProductID";
            db.InsertOrUpdateRecord(sql, obj);
        }
    }
}
