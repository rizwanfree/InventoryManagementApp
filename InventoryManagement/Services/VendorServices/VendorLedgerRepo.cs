using RSDBCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.VendorServices
{
    public class VendorLedgerRepo
    {
        DBSQLite db = new DBSQLite();

        public void DeleteRecord(int rowID)
        {
            string sql = @"DELETE FROM VendorLedger
                         WHERE TransactionID = @TransactionID";
            db.DeleteRecord(sql, new DBParameter { Parameter = "@TransactionID", Value = rowID });
        }
        public DataRow GetSingle(int rowID)
        {
            throw new NotImplementedException();
        }

        public void InsertRecord(object obj)
        {
            string sql = @"INSERT INTO VendorLedger (
                               TransactionID,
                               TransactionDate,
                               VendorID,
                               Particular,
                               Debit,
                               Credit,
                               Reff,
                               DRCR
                           )
                           VALUES (
                               @TransactionID,
                               @TransactionDate,
                               @VendorID,
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
            string sql = @"UPDATE VendorLedger
                           SET TransactionDate = @TransactionDate,
                               VendorID = @VendorID,
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
