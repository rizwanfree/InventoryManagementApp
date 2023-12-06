using RSDBCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.CustomerService
{
    public class CustomerRepo : ICRUD
    {
        DBSQLite db = new DBSQLite();
        public void DeleteRecord(int rowID)
        {
            string sql = @"DELETE FROM Customers
                           WHERE CustomerID = @CustomerID";
            db.DeleteRecord(sql, new DBParameter { Parameter = "@CustomerID", Value = rowID });
        }

        public DataTable GetAll()
        {
            string sql = @"SELECT CustomerID AS 'ID',
                               CustomerName AS 'Supplier Name' ,
                               ContactPerson AS 'Contact Person',
                               Phone,
                               Mobile,
                               Address,
                               NTN,
                               GST
                          FROM Customers";
            return db.GetDataList(sql);
        }

        public DataTable GetByName(string name)
        {
            string sql = @"SELECT CustomerID AS 'ID',
                               CustomerName AS 'Supplier Name' ,
                               ContactPerson AS 'Contact Person',
                               Phone,
                               Mobile,
                               Address,
                               NTN,
                               GST
                          FROM Customers
                          WHERE CustomerName LIKE @CustomerName";
            return db.GetDataList(sql, new DBParameter { Parameter = "@CustomerName", Value = name + '%' });
        }

        public DataTable GetForComboBox()
        {
            string sql = @"SELECT CustomerID AS 'ID',
                               CustomerName AS 'Name' 
                          FROM Customers";
            return db.GetDataList(sql);
        }

        public object GetLastID()
        {
            string sql = @"Select MAX(CustomerID) FROM Customers";
            return db.GetScalarValue(sql);
        }

        public DataRow GetSingle(int rowID)
        {
            string sql = @"SELECT CustomerID AS 'ID',
                            CustomerName AS 'Customer Name' ,
                            ContactPerson AS 'Contact Person',
                            Phone,
                            Mobile,
                            Address,
                            NTN,
                            GST
                        FROM Customers
                        WHERE CustomerID = @CustomerID";
            DataTable dt = db.GetDataList(sql, new DBParameter { Parameter = "@CustomerID", Value = rowID });
            return dt.Rows[0];
        }

        public void InsertRecord(object obj)
        {
            string sql = @"INSERT INTO Customers (
                            
                            CustomerName,
                            ContactPerson,
                            Phone,
                            Mobile,
                            Address,
                            NTN,
                            GST
                        )
                        VALUES (                           
                            @CustomerName,
                            @ContactPerson,
                            @Phone,
                            @Mobile,
                            @Address,
                            @NTN,
                            @GST
                        )";
            db.InsertOrUpdateRecord(sql, obj);                 
        }

        public void UpdateRecord(object obj)
        {
            string sql = @"UPDATE Customers
                           SET 
                               CustomerName = @CustomerName,
                               ContactPerson = @ContactPerson,
                               Phone = @Phone,
                               Mobile = @Mobile,
                               Address = @Address,
                               NTN = @NTN,
                               GST = @GST
                           WHERE CustomerID = @CustomerID";
            db.InsertOrUpdateRecord(sql, obj);
        }
    }
}
