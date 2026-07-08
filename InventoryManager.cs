using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PharmacyManagenmentSystem
{
    // Singleton
    public class InventoryManager
    {
        private IDatabaseAdapter dbAdapter = new DatabaseAdapter();
        private static InventoryManager uniqueInstance;
        private List<Medicine> inventory = new List<Medicine>();

        private InventoryManager() { }

        public static InventoryManager instance()
        {
                if (uniqueInstance == null)
                {
                    uniqueInstance = new InventoryManager();
                }  
            return uniqueInstance;
        }

        public void AddMedication(Medicine medicine)
        {
            string query = "Insert into Medicine values ('" + medicine.Name + "','" + medicine.Type + "','" + medicine.Price + "','" + medicine.Quantity + "');";
            string rec = dbAdapter.Executecmd(query);
            string des = medicine.getType();
            MessageBox.Show(rec + " in " + des);
        }

        public void RemoveMedication(string name)
        {
            string query = "Delete from Medicine where Medname = '" + name + "'";
            string rec = dbAdapter.Executecmd(query);
            MessageBox.Show(rec);
        }

        public void UpdateMedication(string name ,int quantity)
        {
            string query = "Update Medicine set MedQuantity = '" + quantity + "' where MedName = '" + name + "';";
            string rec = dbAdapter.Executecmd(query);
            MessageBox.Show(rec);
        }

    }
}
