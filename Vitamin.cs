using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagenmentSystem
{
    // Concrete Products
    public class Vitamin : Medicine
    {
        public Vitamin(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Type = "Vitamin";
            Quantity = quantity;
        }

        public override string getType()
        {
            return Type;
        }

        public override string GetDescription()
        {
            return "This medicine supplements essential vitamins.";
        }
    }
}