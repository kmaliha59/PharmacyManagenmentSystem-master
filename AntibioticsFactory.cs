using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagenmentSystem
{
    // Concrete Creators

    public class AntibioticsFactory : MedicineFactory
    {
        public override Medicine CreateMedicine(string name, decimal price, int quantity)
        {
            return new Antibiotics(name, price, quantity);
        }
    }
}
