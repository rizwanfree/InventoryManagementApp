using InventoryManagement.Entities;
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

        public DataTable GetRecordsByCustomerID(int customerID)
        {
            string sql = @"SELECT DISTINCT
                            TransactionDate AS 'Date',
                            Particular AS 'Particular',
                            Debit AS 'Debit',
                            Credit AS 'Credit'                            
                        FROM 
                            CustomerLedger
                        WHERE 
                            CustomerID = @CustomerID";
            return db.GetDataList(sql, new DBParameter { Parameter = "@CustomerID", Value= customerID });
        }

        public DataRow GetPreviousBalance(string fromDate, int customerID)
        {
            string sql = @"SELECT 
                            '' AS 'Date',
                            'Previous Balance' AS 'Particular',
                            '' AS 'Debit',
                            '' AS 'Credit',
                            SUM(Debit) - SUM(Credit) AS 'Balance'
                        FROM 
                            CustomerLedger
                        WHERE 
                            CustomerID = @CustomerID
                            AND TransactionDate < @FromDate";
            List<DBParameter> paras = new List<DBParameter>();
            paras.Add(new DBParameter { Parameter = "@CustomerID", Value = customerID });
            paras.Add(new DBParameter { Parameter = "@FromDate", Value = fromDate });
            return db.GetDataList(sql, paras.ToArray()).Rows[0];
        }

        public DataTable GetRecordsByCustomerIDAndDate(int customerID, string fromDate, string endDate)
        {
            string sql = @"SELECT DISTINCT
                            TransactionDate AS 'Date',
                            Particular AS 'Particular',
                            Debit AS 'Debit',
                            Credit AS 'Credit'                            
                        FROM 
                            CustomerLedger
                        WHERE 
                            CustomerID = @CustomerID
                        AND TransactionDate BETWEEN @FromDate AND @EndDate";
            List<DBParameter> paras = new List<DBParameter>();
            paras.Add(new DBParameter { Parameter = "@CustomerID", Value = customerID });
            paras.Add(new DBParameter { Parameter = "@FromDate", Value = fromDate });
            paras.Add(new DBParameter { Parameter = "@EndDate", Value = endDate });
            return db.GetDataList(sql, paras.ToArray());
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
