using RSDBCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.ProductServices
{
    public class ProductRepo : ICRUD
    {
        DBSQLite db = new DBSQLite();
        public void DeleteRecord(int rowID)
        {
            string sql = @"DELETE FROM Products
                           WHERE ProductID = @ProductID";
            db.DeleteRecord(sql, new DBParameter { Parameter = "@ProductID", Value = rowID });
        }


        public int GetLastMaxID()
        {
            string sql = @"SELECT MAX(ProductID) FROM Products";
            return Convert.ToInt32(db.GetScalarValue(sql));
        }

        public DataTable GetAll()
        {
            string sql = @"SELECT p.ProductID AS 'ID',
                           p.ProductName AS 'Product Name',
                           p.KGFT AS 'KG Per Foot',
                           c.CategoryName AS 'Category'       
                           FROM Products p
                           INNER JOIN Categories c ON c.CategoryID = p.CategoryID";
            return db.GetDataList(sql);
        }

        public DataTable GetByName(string name)
        {
            string sql = @"SELECT p.ProductID AS 'ID',
                           p.ProductName AS 'Name',
                           p.KGFT AS 'KG Per Foot',
                           c.CategoryName AS 'Category'       
                           FROM Products p
                           INNER JOIN Categories c ON c.CategoryID = p.CategoryID
                           WHERE p.ProductName LIKE @ProductName";
            return db.GetDataList(sql, new DBParameter { Parameter = "@ProductName", Value = '%' + name + '%'});
        }

        public DataTable GetForComboBox()
        {
            string sql = @"SELECT p.ProductID AS 'ID',
                           c.CategoryName || ' ' || p.ProductName AS 'Name'   
                           FROM Products p
                           INNER JOIN Categories c ON c.CategoryID = p.CategoryID";
            return db.GetDataList(sql);
        }

        public object GetScaler(int id)
        {
            throw new NotImplementedException();
        }

        public DataRow GetSingle(int rowID)
        {
            string sql = @"SELECT 
                           p.ProductName AS 'Name',
                           p.KGFT AS 'KG Per Foot',
                           p.CategoryID AS 'Category'       
                           FROM Products p
                           WHERE p.ProductID = @ProductID";
            DataTable dt = db.GetDataList(sql,new DBParameter { Parameter = "@ProductID", Value=rowID});
            DataRow dr = dt.Rows[0];
            return dr;
        }

        public void InsertRecord(object obj)
        {
            string sql = @"INSERT INTO Products (                         
                         ProductName,
                         KGFT,
                         CategoryID
                         )
                         VALUES (                             
                             @ProductName,
                             @KGFT,
                             @CategoryID
                         )";
            db.InsertOrUpdateRecord(sql, obj);
        }

        public void UpdateRecord(object obj)
        {
            string sql = @"UPDATE Products
                           SET ProductName = @ProductName,
                               KGFT = @KGFT,
                               CategoryID = @CategoryID
                           WHERE ProductID = @ProductID";
            db.InsertOrUpdateRecord(sql, obj);
        }
    }
}
