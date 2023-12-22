using RSDBCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.CustomerService
{
    public class CustomerLedgerRepo
    {
        DBSQLite db = new DBSQLite();
        public void DeleteRecord(int rowID)
        {
            string sql = @"DELETE FROM CustomerLedger
                         WHERE TransactionID = @TransactionID";
            db.DeleteRecord(sql, new DBParameter { Parameter = "@TransactionID", Value = rowID });
        }
        public DataRow GetSingle(int rowID)
        {
            throw new NotImplementedException();
        }

        public void InsertRecord(object obj)
        {
            string sql = @"INSERT INTO CustomerLedger (
                               
                               TransactionDate,
                               CustomerID,
                               Particular,
                               Debit,
                               Credit,
                               Reff,
                               DRCR
                           )
                           VALUES (
                               
                               @TransactionDate,
                               @CustomerID,
                               @Particular,
                               @Debit,
                               @Credit,
                               @Reff,
                               @DRCR
                           )";
            db.InsertOrUpdateRecord(sql, obj);
        }

        public void UpdateRecord(object obj)
        {
            string sql = @"UPDATE CustomerLedger
                           SET TransactionDate = @TransactionDate,
                               CustomerID = @CustomerID,
                               Particular = @Particular,
                               Debit = @Debit,
                               Credit = @Credit,
                               Reff = @Reff,
                               DRCR = @DRCR
                         WHERE TransactionID = @TransactionID";
            db.InsertOrUpdateRecord(sql, obj);
        }
    }
}
