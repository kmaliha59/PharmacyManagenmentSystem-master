using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagenmentSystem
{
    // Abstract Product

    public abstract class Medicine
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public string Type { get; protected set; }
        public int Quantity { get; protected set; }

        public abstract string getType();
        public abstract string GetDescription();
    }
}
