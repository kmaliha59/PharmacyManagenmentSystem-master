using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagenmentSystem
{
    public class CardPayment : Payment
    {

        public CardPayment(Cardbehavior cardbehavior)
        {
           this.cardbehavior = cardbehavior;
        }

        public override decimal processPayment(decimal amount) 
        {
            return cardbehavior.calculateDiscount(amount);
        }

        public override void makePayment()
        {
            cardbehavior.details();
        }
       
    }


}
    

