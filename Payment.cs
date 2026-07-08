using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagenmentSystem
{
    public abstract class Payment
    {
        protected Cashbehavior cashbehavior;
        protected Cardbehavior cardbehavior;

        public void setCashbehavior(Cashbehavior cb)
        {
            cashbehavior = cb;
        }
        public void setCardbehavior(Cardbehavior cb)
        {
            cardbehavior = cb;
        }

        public abstract decimal processPayment(decimal amount);
        public abstract void makePayment();
    }
}
