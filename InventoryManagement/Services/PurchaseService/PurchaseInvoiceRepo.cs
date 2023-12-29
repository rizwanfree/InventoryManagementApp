using RSDBCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.PurchaseService
{
    public class PurchaseInvoiceRepo : ICRUD
    {
        DBSQLite db = new DBSQLite();
        public void DeleteRecord(int rowID)
        {
            string sql = @"DELETE FROM PurchaseInvoice
                           WHERE PurchaseInvoiceID = @PurchaseInvoiceID";
            db.DeleteRecord(sql, new DBParameter { Parameter = "@PurchaseInvoiceID", Value = rowID });
        }

        public int GetLastInvoiceID()
        {
            string sql = @"SELECT MAX(PurchaseInvoiceID)
                           FROM PurchaseInvoice";
            return Convert.ToInt32(db.GetScalarValue(sql));
        }

        public DataTable GetAll()
        {
            throw new NotImplementedException();
        }

        public DataTable GetByName(string name)
        {
            string sql = @"SELECT DISTINCT si.PurchaseInvoiceID AS 'ID',
                        si.InvoiceDate AS 'Date',
                        si.BillNumber AS 'Bill #',
                        c.VendorName AS 'Supplier',
                        SUM(sid.Total) AS 'Invoice Amount'       
                        FROM PurchaseInvoice si
                        INNER JOIN Vendors c ON si.VendorID = c.VendorID
                        INNER JOIN PurchaseInvoiceDetail sid ON sid.PurchaseInvoiceID = si.PurchaseInvoiceID
                        WHERE c.VendorName LIKE @VendorName
                        GROUP BY si.PurchaseInvoiceID";

            return db.GetDataList(sql, new DBParameter { Parameter = "@VendorName", Value = '%' + name.ToUpper() + '%' });
        }

        public DataTable GetByDate(string fromDate, string endDate)
        {
            string sql = @"SELECT DISTINCT si.PurchaseInvoiceID AS 'ID',
                        si.InvoiceDate AS 'Date',
                        si.BillNumber AS 'Bill #',
                        c.VendorName AS 'Supplier',
                        SUM(sid.Total) AS 'Invoice Amount'       
                        FROM PurchaseInvoice si
                        INNER JOIN Vendors c ON si.VendorID = c.VendorID
                        INNER JOIN PurchaseInvoiceDetail sid ON sid.PurchaseInvoiceID = si.PurchaseInvoiceID
                        WHERE si.InvoiceDate BETWEEN @FromDate AND @EndDate
                        GROUP BY si.PurchaseInvoiceID";
            List<DBParameter> paras = new List<DBParameter>();
            paras.Add(new DBParameter { Parameter = "@FromDate", Value = fromDate });
            paras.Add(new DBParameter { Parameter = "@EndDate", Value = endDate });
            return db.GetDataList(sql, paras.ToArray());
        }

        public DataTable GetForComboBox()
        {
            throw new NotImplementedException();
        }

        public DataRow GetSingle(int rowID)
        {
            string sql = @"SELECT PurchaseInvoiceID,
                           InvoiceDate,
                           BillNumber,
                           VendorID
                           FROM PurchaseInvoice
                           WHERE PurchaseInvoiceID = @PurchaseInvoiceID";
            return db.GetDataList(sql, new DBParameter { Parameter = "@PurchaseInvoiceID", Value = rowID }).Rows[0];
        }

        public void InsertRecord(object obj)
        {
            string sql = @"INSERT INTO PurchaseInvoice (
                                
                                InvoiceDate,
                                BillNumber,
                                VendorID
                            )
                            VALUES (                                
                                @InvoiceDate,
                                @BillNumber,
                                @VendorID
                            )";
            db.InsertOrUpdateRecord(sql, obj);
        }

        public void UpdateRecord(object obj)
        {
            string sql = @"INSERT INTO PurchaseInvoice (                                
                                InvoiceDate,
                                BillNumber,
                                VendorID
                            )
                            VALUES (                                
                                @InvoiceDate,
                                @BillNumber,
                                @VendorID
                            )";
            db.InsertOrUpdateRecord(sql, obj);
        }
    }
}
