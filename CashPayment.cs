using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagenmentSystem
{
    public class CashPayment : Payment
    {

        public CashPayment(Cashbehavior cashbehavior)
        {
            this.cashbehavior = cashbehavior;
        }

        public override decimal processPayment(decimal amount)
        {
            return cashbehavior.calculateDiscount(amount);
        }

        public override void makePayment()
        {
            cashbehavior.details();
        }
    }
}
