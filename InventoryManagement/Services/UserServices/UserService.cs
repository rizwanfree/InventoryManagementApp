using RSDBCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.UserServices
{
    public class UserService : ICRUD
    {
        DBSQLite db = new DBSQLite();
        public void DeleteRecord(int rowID)
        {
            try
            {
                string sql = @"DELETE FROM Users
                           WHERE rowId = @rowID";
                db.DeleteRecord(sql, new DBParameter { Parameter = "@rowID", Value = rowID });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetAll()
        {
            try
            {
                string sql = @"SELECT
                           rowId,
                           Name,
                           Username,                           
                           Phone,
                           Email,
                           CASE Status
                               WHEN 1 THEN 'ACTIVE'
                               ELSE 'In-ACITVE'
                           END AS 'Status'
                      FROM Users";
                return db.GetDataList(sql);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetByName(string name)
        {
            try
            {
                string sql = @"SELECT
                           rowId,
                           Name,
                           Username,                           
                           Phone,
                           Email,
                           CASE Status
                               WHEN 1 THEN 'ACTIVE'
                               ELSE 'In-ACITVE'
                           END AS 'Status'
                      FROM Users
                      WHERE Name LIKE @Name ";
                return db.GetDataList(sql, new DBParameter { Parameter = "@Name", Value = '%' + name + '%'});
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable GetForComboBox()
        {
            throw new NotImplementedException();
        }

        public DataRow GetSingle(int rowID)
        {
            try
            {
                string sql = @"SELECT
                           
                           Name,
                           Username,
                           Password,
                           Phone,
                           Email,
                           Status
                      FROM Users
                      WHERE rowId = @rowID";
                DataTable dt = db.GetDataList(sql, new DBParameter { Parameter = "@rowID", Value = rowID });
                DataRow dr = dt.Rows[0];
                return dr;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void InsertRecord(object obj)
        {
            try
            {
                string sql = @"INSERT INTO Users (
                              Name,
                              Username,
                              Password,
                              Phone,
                              Email,
                              Status
                          )
                          VALUES (
                              @Name,
                              @Username,
                              @Password,
                              @Phone,
                              @Email,
                              @Status
                          )";

                db.InsertOrUpdateRecord(sql, obj);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void UpdateRecord(object obj)
        {
            try
            {
                string sql = @"UPDATE Users
                           SET Name = @Name,
                               Username = @Username,
                               Password = @Password,
                               Phone = @Phone,
                               Email = @Email,
                               Status = @Status
                               WHERE rowId = @rowID";

                db.InsertOrUpdateRecord(sql, obj);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
