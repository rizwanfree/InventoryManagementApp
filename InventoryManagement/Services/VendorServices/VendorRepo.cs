using RSDBCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.VendorServices
{
    public class VendorRepo : ICRUD
    {
        DBSQLite db = new DBSQLite();
        public void DeleteRecord(int rowID)
        {
            string sql = @"DELETE FROM Vendors
                           WHERE VendorID = @VendorID";
            db.DeleteRecord(sql, new DBParameter { Parameter = "@VendorID", Value = rowID });
        }

        public DataTable GetAll()
        {
            string sql = @"SELECT VendorID AS 'ID',
                               VendorName AS 'Supplier Name' ,
                               ContactPerson AS 'Contact Person',
                               Phone,
                               Mobile,
                               Address,
                               NTN,
                               GST
                          FROM Vendors";
            return db.GetDataList(sql);
        }

        public DataTable GetByName(string name)
        {
            string sql = @"SELECT VendorID AS 'ID',
                               VendorName AS 'Supplier Name' ,
                               ContactPerson AS 'Contact Person',
                               Phone,
                               Mobile,
                               Address,
                               NTN,
                               GST
                          FROM Vendors
                          WHERE VendorName LIKE @VendorName";
            return db.GetDataList(sql, new DBParameter { Parameter = "@VendorName", Value = name + '%'});
        }

        public DataTable GetForComboBox()
        {
            string sql = @"SELECT VendorID AS 'ID',
                               VendorName AS 'Name' 
                          FROM Vendors";
            return db.GetDataList(sql);
        }

        public DataRow GetSingle(int rowID)
        {
            string sql = @"SELECT VendorID AS 'ID',
                               VendorName AS 'Supplier Name' ,
                               ContactPerson AS 'Contact Person',
                               Phone,
                               Mobile,
                               Address,
                               NTN,
                               GST
                          FROM Vendors
                          WHERE VendorID = @VendorID";
            DataTable dt = db.GetDataList(sql,new DBParameter { Parameter= "@VendorID", Value = rowID });
            return dt.Rows[0];
        }

        public void InsertRecord(object obj)
        {
            string sql = @"INSERT INTO Vendors (
                            
                            VendorName,
                            ContactPerson,
                            Phone,
                            Mobile,
                            Address,
                            NTN,
                            GST
                        )
                        VALUES (                           
                            @VendorName,
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
            string sql = @"UPDATE Vendors
                           SET 
                               VendorName = @VendorName,
                               ContactPerson = @ContactPerson,
                               Phone = @Phone,
                               Mobile = @Mobile,
                               Address = @Address,
                               NTN = @NTN,
                               GST = @GST
                           WHERE VendorID = @VendorID";
            db.InsertOrUpdateRecord(sql, obj);
        }
    }
}
