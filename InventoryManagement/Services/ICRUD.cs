using RSDBCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services
{
    public interface ICRUD
    {
        
        void InsertRecord(object obj);
        void UpdateRecord(object obj);
        void DeleteRecord(int rowID);
        DataTable GetAll();
        DataTable GetForComboBox();
        DataRow GetSingle(int rowID);
        DataTable GetByName(string name);
    }
}
