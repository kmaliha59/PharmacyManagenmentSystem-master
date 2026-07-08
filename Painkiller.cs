using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagenmentSystem
{
    // Concrete Products

    public class Painkiller : Medicine 
    {
        public Painkiller(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Type = "Painkiller";
            Quantity = quantity;
        }

        public override string getType()
        {
            return Type;
        }
        public override string GetDescription()
        {
            return "This medicine provides relief from pain.";
        }
    }
}