using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagenmentSystem
{
    public class SilverCard : Cardbehavior
    {
        decimal discount = 7;
        public decimal calculateDiscount(decimal amount)
        {
            return (amount * discount) / 100;
        }
        public void details()
        {
            MessageBox.Show("7% Discount For silver Card");
            
        }
    }
}
