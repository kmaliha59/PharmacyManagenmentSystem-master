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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace PharmacyManagenmentSystem
{
    public partial class UpdateStock : Form
    {
        IDatabaseAdapter dbAdapter = new DatabaseAdapter();
        InventoryManager inventoryManager =  InventoryManager.instance();
        List<string> Items = new List<string> { };
        public UpdateStock()
        {
            InitializeComponent();
        }


        private void Backbtn_Click(object sender, EventArgs e)
        {
            AdminDashboard ui = new AdminDashboard();
            ui.Show();
            this.Hide();
        }


        private void TypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NamecomboBox.SelectedItem = null;
            if (TypecomboBox.SelectedItem != null)
            { 
                Items.Clear();
                NamecomboBox.Items.Clear();
                QuantitytextBox.Clear();
                string query = "Select MedName from Medicine where MedType = '" + TypecomboBox.SelectedItem.ToString() + "' ";
                Items = dbAdapter.GetInList(query);
                foreach (string item in Items)
                {
                    NamecomboBox.Items.Add(item);
                }
            }

           
        }

        private void NamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NamecomboBox.SelectedItem != null)
            {
                QuantitytextBox.Clear();
                string query = "Select MedQuantity from Medicine where MedName = '" + NamecomboBox.SelectedItem.ToString() + "' ";
                QuantitytextBox.Text = dbAdapter.GetInText(query);
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            if (TypecomboBox.SelectedItem == null || NamecomboBox.SelectedItem == null || QuantitytextBox.Text == null)
            {
                MessageBox.Show("Fill all Feilds");
            }
            else
            {
                string name = NamecomboBox.SelectedItem.ToString();
                int quantity = int.Parse(QuantitytextBox.Text);
                inventoryManager.UpdateMedication(name, quantity);
                ResetMethod.Reset(this.Controls);
            }
        }



    }
}

