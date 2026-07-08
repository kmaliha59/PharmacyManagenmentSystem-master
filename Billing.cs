using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PharmacyManagenmentSystem
{
    public partial class Billing : Form
    {
        public List<Tuple<string, int, decimal, int>> _medicineList;
        public int items;
        public decimal amount;
        public decimal discount;
        public decimal total;

        private Payment payment;
        IDatabaseAdapter dbAdapter = new DatabaseAdapter();
        public Billing()
        {
            InitializeComponent();
        }
        private void Billing_Load(object sender, EventArgs e)
        {
            TotalItemtextBox.Text = items.ToString();
            AmounttextBox.Text = amount.ToString();
        }

        private void PayTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PayTypecomboBox.SelectedItem.ToString() == "Cash")
            {

                CardTypecomboBox.Enabled = false;
                AccNametextBox.Enabled = false;
                AccNotextBox.Enabled = false;

            }
            else
            {
                CardTypecomboBox.Enabled = true;
                AccNametextBox.Enabled = true;
                AccNotextBox.Enabled = true;

            }
        }


        private void GetTotalbtn_Click(object sender, EventArgs e)
        {
            if (PayTypecomboBox.SelectedItem == null)
            {
                MessageBox.Show("Select payment type");
            }
            else
            {
                if (PayTypecomboBox.SelectedItem.ToString() == "Cash")
                {
                    if (amount > 3000)
                    {
                        payment = new CashPayment(new HighAmount());
                    }
                    else
                    {
                        payment = new CashPayment(new LowAmount());
                    }   
                }
                else
                {
                    if (CardTypecomboBox.SelectedItem.ToString() != null)
                    {
                        if (CardTypecomboBox.SelectedItem.ToString() == "Gold")
                        {
                            payment = new CardPayment(new GoldCard());
                        }
                        else
                        {
                            payment = new CardPayment(new SilverCard());
                        }
                    }
                }
                discount = payment.processPayment(amount);
                DiscounttextBox.Text = discount.ToString();
                total = amount - discount;
                TotaltextBox.Text = total.ToString();
            }
        }

        private void Paybtn_Click(object sender, EventArgs e)
        {
            string CName = CNametextBox.Text;
            int CNo = Convert.ToInt32(ContacttextBox.Text);
            DateTime date = dateTimePicker1.Value;
            string Paytype = PayTypecomboBox.SelectedItem.ToString();


            if (TotaltextBox == null)
            {
                MessageBox.Show("fill all feilds");
                Invoicebtn.Enabled = false;
            }
            else
            {
                string query = "Insert into Invoice values ('" + CName + "','" + CNo + "','" + items + "','" + total + "','" + date + "','" + Paytype + "');";
                string rec = dbAdapter.Executecmd(query);
                MessageBox.Show(rec);
                Invoicebtn.Enabled = true;
                Logoutbtn.Enabled = true;
            }
        }

        private void Invoicebtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Pharmacy Bill", 400, 800);
            printPreviewDialog1.ShowDialog();
            ResetMethod.Reset(this.Controls);

        }



        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string R1, R2, R3, R4, R5;

            R1 = "****************************************\n";
            R1 += "**            Pharmacy Bill          **\n";
            R1 += "*****************************************";

            R2 = "\nDate: " + dateTimePicker1.Value;
            R2 += "\nInvoice Number: 10034";
            R2 += "\nBilled to: " + CNametextBox.Text;
            R2 += "\nContact Numer: " + ContacttextBox.Text;
            R2 += "\nPayment Type: " + PayTypecomboBox.SelectedItem;

            R3 = "\n\t****************************************\n";
            R3 += "\tName\tQuantity\tPrice\tTotal ";
            R3 += "\n\t****************************************\n";
            foreach (var medicine in _medicineList)
            {
                string name = medicine.Item1;
                int quantity = medicine.Item2;
                decimal price = medicine.Item3;
                int SubTotal = medicine.Item4;

                R3 += $"\n\t{name} \t{quantity}\t{price}\t{SubTotal}";
            }
            R3 += "\n\t****************************************";

            R4 = "\nItems:    " + items;
            R4 += "\nAmount:   " + amount;
            R4 += "\nDiscount: " + discount;
            R4 += "\nTotal:    " + total;

            R5 = "\n*************************************************";
            R5 += "\n\tTerms And Condition Applies \n\t(Pharmacy Billing System)";
            R5 += "\n************************************************";


            e.Graphics.DrawString(R1, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString(R2, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 90));
            e.Graphics.DrawString(R3, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 230));
            e.Graphics.DrawString(R4, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 380));
            e.Graphics.DrawString(R5, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(10, 500));


        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            LoginFormed ui = new LoginFormed();
            this.Hide();
            ui.Show();
        }
    }
}
