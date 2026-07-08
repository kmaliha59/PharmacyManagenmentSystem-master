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


namespace PharmacyManagenmentSystem
{
    public partial class CheckStock : Form
    {
        public CheckStock()
        {
            InitializeComponent();
        }

        IDatabaseAdapter dbAdapter = new DatabaseAdapter();
        DataTable dt;
        

        private void Searchbtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text == "")
                {
                    string query = "Select * from Medicine";
                    dataGridView1.DataSource = null;
                    dt = dbAdapter.GetInDataTable(query);
                    dataGridView1.DataSource = dt;
                    ColName();
                }
                else
                {
                    string query = "Select * from Medicine Where '" + textBox1.Text + "' in (MedName,MedType) ";
                    dataGridView1.DataSource = null;
                    dt = dbAdapter.GetInDataTable(query);
                    dataGridView1.DataSource = dt;
                    ColName();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void CheckStock_Load(object sender, EventArgs e)
        {
            string query = "Select * from Medicine";
            dt = dbAdapter.GetInDataTable(query);
            dataGridView1.DataSource = dt;
            ColName();
        }

        private void ColName()
        {
            dataGridView1.Columns[0].HeaderCell.Value = "Name";
            dataGridView1.Columns[1].HeaderCell.Value = "Type";
            dataGridView1.Columns[2].HeaderCell.Value = "Price";
            dataGridView1.Columns[3].HeaderCell.Value = "Quantity";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminDashboard ui = new AdminDashboard();
            ui.Show();
            this.Hide();
        }
    }
}
