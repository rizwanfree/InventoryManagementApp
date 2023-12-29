using RSDBCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.SellService
{
    public class SellInvoiceRepo : ICRUD
    {
        DBSQLite db = new DBSQLite();
        public void DeleteRecord(int rowID)
        {
            string sql = @"DELETE FROM SellInvoice
                           WHERE SellInvoiceID = @SellInvoiceID";
            db.DeleteRecord(sql, new DBParameter { Parameter = "@SellInvoiceID", Value = rowID });
        }

        public int GetLastInvoiceID()
        {
            string sql = @"SELECT MAX(SellInvoiceID)
                           FROM SellInvoice";
            return Convert.ToInt32(db.GetScalarValue(sql));
        }

        public DataTable GetAll()
        {
            throw new NotImplementedException();
        }

        public DataTable GetByName(string name)
        {
            string sql = @"SELECT DISTINCT si.SellInvoiceID AS 'ID',
                        si.InvoiceDate AS 'Date',
                        si.BillNumber AS 'Bill #',
                        c.CustomerName AS 'Customer',
                        SUM(sid.Total) AS 'Invoice Amount'       
                        FROM SellInvoice si
                        INNER JOIN Customers c ON si.CustomerID = c.CustomerID
                        INNER JOIN SellInvoiceDetail sid ON sid.SellInvoiceID = si.SellInvoiceID
                        WHERE c.CustomerName LIKE @CustomerName
                        GROUP BY si.SellInvoiceID";

            return db.GetDataList(sql, new DBParameter { Parameter = "@CustomerName", Value = '%' + name.ToUpper() + '%'});
        }

        public DataTable GetByDate(string fromDate, string endDate)
        {
            string sql = @"SELECT DISTINCT si.SellInvoiceID AS 'ID',
                        si.InvoiceDate AS 'Date',
                        si.BillNumber AS 'Bill #',
                        c.CustomerName AS 'Customer',
                        SUM(sid.Total) AS 'Invoice Amount'       
                        FROM SellInvoice si
                        INNER JOIN Customers c ON si.CustomerID = c.CustomerID
                        INNER JOIN SellInvoiceDetail sid ON sid.SellInvoiceID = si.SellInvoiceID
                        WHERE si.InvoiceDate BETWEEN @FromDate AND @EndDate
                        GROUP BY si.SellInvoiceID";
            List<DBParameter> paras = new List<DBParameter>();
            paras.Add(new DBParameter { Parameter = "@FromDate", Value = fromDate });
            paras.Add(new DBParameter { Parameter = "@EndDate",Value = endDate });
            return db.GetDataList(sql, paras.ToArray());
        }

        public DataTable GetForComboBox()
        {
            throw new NotImplementedException();
        }

        public DataRow GetSingle(int invoiceID)
        {
            string sql = @"SELECT SellInvoiceID,
                           InvoiceDate,
                           BillNumber,
                           CustomerID
                           FROM SellInvoice
                           WHERE SellInvoiceID = @SellInvoiceID";
            return db.GetDataList(sql, new DBParameter { Parameter = "@SellInvoiceID", Value = invoiceID}).Rows[0];
            
        }

        public void InsertRecord(object obj)
        {
            string sql = @"INSERT INTO SellInvoice (                                
                                InvoiceDate,
                                BillNumber,
                                CustomerID
                            )
                            VALUES (                                
                                @InvoiceDate,
                                @BillNumber,
                                @CustomerID
                            )";
            db.InsertOrUpdateRecord(sql, obj);
        }

        public void UpdateRecord(object obj)
        {
            string sql = @"INSERT INTO SellInvoice (                                
                                InvoiceDate,
                                BillNumber,
                                CustomerID
                            )
                            VALUES (                                
                                @InvoiceDate,
                                @BillNumber,
                                @CustomerID
                            )";
            db.InsertOrUpdateRecord(sql, obj);
        }
    }
}
