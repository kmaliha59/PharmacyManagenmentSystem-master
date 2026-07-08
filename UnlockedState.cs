using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagenmentSystem
{
    public class UnlockedState : IAppState
    {
        private bool locked = false;
        public bool GetState()
        {
            return locked;
        }

        public string ProcessAction()
        {
            // Perform normal actions
            return "Action performed successfully.";
        }
    }
}
