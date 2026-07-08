using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagenmentSystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AddMedicine_Click(object sender, EventArgs e)
        {
          AddMedicine ad = new AddMedicine();
           ad.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateStock ad1 = new UpdateStock();
            ad1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckStock ad2 = new CheckStock();
            ad2.Show();
            this.Hide();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoginFormed log = new LoginFormed();
            log.Show();
            this.Hide();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
