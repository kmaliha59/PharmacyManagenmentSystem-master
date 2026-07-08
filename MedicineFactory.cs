using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagenmentSystem
{
    // Creator (Abstract Factory)

    public abstract class MedicineFactory
    {
        public abstract Medicine CreateMedicine(string name, decimal price, int quantity);
    }
}
