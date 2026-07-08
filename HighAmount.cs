using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagenmentSystem
{
    public class HighAmount : Cashbehavior
    {
        decimal discount = 12;
        public decimal calculateDiscount(decimal amount)
        {
            return (amount * discount)/100;
        }
        public void details()
        {
            MessageBox.Show("12% Discount On Amount More than 3000");
        }
    }
}
