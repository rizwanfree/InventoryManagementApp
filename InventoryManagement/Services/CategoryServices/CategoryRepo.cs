using RSDBCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.CategoryServices
{
    public class CategoryRepo : ICRUD
    {
        DBSQLite db = new DBSQLite();
        public void DeleteRecord(int rowID)
        {
            string sql = @"DELETE FROM Categories
                         WHERE CategoryID = @CategoryID";
            db.DeleteRecord(sql, new DBParameter { Parameter = "@CategoryID", Value = rowID});
        }

        public DataTable GetAll()
        {
            string sql = @"SELECT 
                                CategoryID AS 'ID', 
                                CategoryName AS 'Name'
                                FROM Categories
                                ORDER BY CategoryName";
            return db.GetDataList(sql);
        }

        public DataTable GetByName(string name)
        {
            string sql = @"SELECT 
                                CategoryID AS 'ID', 
                                CategoryName AS 'Name'
                                FROM Categories
                                WHERE CategoryName LIKE @CategoryName";
            return db.GetDataList(sql, new DBParameter { Parameter = "@CategoryName", Value = $"%{name}%"});
        }

        public DataTable GetForComboBox()
        {
            throw new NotImplementedException();
        }

        public object GetScaler(int id)
        {
            throw new NotImplementedException();
        }

        public DataRow GetSingle(int rowID)
        {
            string sql = @"SELECT 
                                CategoryID AS 'ID', 
                                CategoryName AS 'Name'
                                FROM Categories
                                WHERE CategoryID = @CategoryID";
            DataTable dt = db.GetDataList(sql, new DBParameter { Parameter = "@CategoryID", Value = rowID });
            DataRow dr = dt.Rows[0];
            return dr;
        }

        public void InsertRecord(object obj)
        {
            string sql = @"INSERT INTO Categories (
                           
                           CategoryName
                       )
                       VALUES (
                          
                           @CategoryName
                       )";
            db.InsertOrUpdateRecord(sql, obj);
        }

        public void UpdateRecord(object obj)
        {
            string sql = @"UPDATE Categories
                         SET CategoryName = @CategoryName
                         WHERE CategoryID = @CategoryID";
            db.InsertOrUpdateRecord(sql, obj);
                            
        }
    }
}
