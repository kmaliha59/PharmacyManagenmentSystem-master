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
    public partial class LoginFormed : Form
    {
        //private AppContext appContext;
        private AppContext appContext;
        private ILoginServices loginService;
        private IDatabaseAdapter dbAdapter;

        public LoginFormed()
        {
            InitializeComponent();
            appContext = new AppContext();
            dbAdapter = new DatabaseAdapter();
            loginService = new LoginProxy(new LoginService(dbAdapter));
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            bool status = appContext.GetState();
            string result = appContext.ProcessAction();

            string username = textBox1.Text;
            string password = textBox2.Text;

            if (status)
            {
                label1.Visible = true;
                label1.Text = result;
            }
            else
            {
                try
                {
                    if (loginService.Login(username, password))
                    {
                        string managerQuery = $"Select * from Manager where ManagerName = '{username}' AND password = '{password}'";
                        if (dbAdapter.ValidateUser(managerQuery))
                        {
                            MessageBox.Show("Login Successfully As Manager..");
                            AdminDashboard panel = new AdminDashboard();
                            panel.Show();
                        }
                        else
                        {
                            MessageBox.Show("Login Successfully As User..");
                            AddOrder panel = new AddOrder();
                            panel.Show();
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect id or password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //public LoginFormed()
            //{
            //    InitializeComponent();
            //    appContext = new AppContext();

            //}
            //private void Loginbtn_Click(object sender, EventArgs e)
            //{
            //    bool status = appContext.GetState();
            //    string result = appContext.ProcessAction();

            //    string username = textBox1.Text;
            //    string password = textBox2.Text;

            //    string query = "Select * from Users where UserName = '" + username + "' AND password = '" + password + "'";
            //    string query1 = "Select * from Manager where ManagerName = '" + username + "' AND password = '" + password + "'";

            //    if (status == true) 
            //    {
            //        label1.Visible = true;
            //        label1.Text = result;
            //    }
            //    else
            //    {

            //        if (dbAdapter.ValidateUser(query))
            //        {
            //            MessageBox.Show("Login Successfully As User..");
            //            AddOrder Pannel = new AddOrder();
            //            Pannel.Show();
            //            this.Hide();
            //        }
            //        else if (dbAdapter.ValidateUser(query1))
            //        {
            //            MessageBox.Show("Login Successfully As Manager..");
            //            AdminDashboard Pannel = new AdminDashboard();
            //            Pannel.Show();
            //            this.Hide();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Incorrect id or password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            textBox1.Clear();
            //            textBox2.Clear();
            //        }
            //    }
        }

        private void LoginFormed_Load(object sender, EventArgs e)
        {

        }
    }
 }

