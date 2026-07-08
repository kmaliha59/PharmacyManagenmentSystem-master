using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Xml.Linq;

namespace PharmacyManagenmentSystem
{
    public partial class AddMedicine : Form
    {
        MedicineFactory factory;
        InventoryManager inventoryManager = InventoryManager.instance();

        public AddMedicine()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string type = CategoryComboBox.Text;
            string name = NameTextBox.Text;
            decimal price = Convert.ToDecimal(PriceTextBox.Text);
            int quantity = Convert.ToInt32(QuantityTextBox.Text);
    

            switch (type)
            {
                case "Painkiller":
                    factory = new PainkillerFactory();
                    break;
                case "Vitamin":
                    factory = new VitaminFactory();
                    break;
                case "Antibiotic":
                    factory = new AntibioticsFactory();
                    break;
                default:
                    throw new ArgumentException("Invalid medicine category.");
            }

            Medicine medicine = factory.CreateMedicine(name, price, quantity);
            inventoryManager.AddMedication(medicine);
            ResetMethod.Reset(this.Controls);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            inventoryManager.RemoveMedication(name);
            ResetMethod.Reset(this.Controls);
        }

    }
}
