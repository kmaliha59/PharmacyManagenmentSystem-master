using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagenmentSystem
{
    public class LowAmount : Cashbehavior
    {
        decimal discount = 5;
        public decimal calculateDiscount(decimal amount)
        {
            return (amount * discount) / 100;
        }
        public void details()
        {
            MessageBox.Show("5% Discount On Amount Less than 3000");
        }
    }
}
