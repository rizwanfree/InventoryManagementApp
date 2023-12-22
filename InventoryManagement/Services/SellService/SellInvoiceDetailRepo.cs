using RSDBCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.SellService
{
    public class SellInvoiceDetailRepo : ICRUD
    {
        readonly DBSQLite db = new DBSQLite();
        public void DeleteRecord(int rowID)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {
            throw new NotImplementedException();
        }

        public DataTable GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public DataTable GetForComboBox()
        {
            throw new NotImplementedException();
        }

        public DataRow GetSingle(int rowID)
        {
            throw new NotImplementedException();
        }

        public void InsertRecord(object obj)
        {
            string sql = @"INSERT INTO SellInvoiceDetail (                                    
                                      ProductID,
                                      SellInvoiceID,
                                      Quantity,
                                      Rate,
                                      Total
                                  )
                                  VALUES (                                     
                                      @ProductID,
                                      @SellInvoiceID,
                                      @Quantity,
                                      @Rate,
                                      @Total
                                  )";
            db.InsertOrUpdateRecord(sql, obj);
        }

        public void UpdateRecord(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
