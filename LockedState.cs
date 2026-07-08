using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagenmentSystem
{
    // Concrete state classes
    public class LockedState : IAppState
    {
        private bool locked = true;
        public bool GetState()
        {
            return locked;
        }
        public string ProcessAction()
        {    
            // Return locked message during restricted hours
            return "Application is locked. Please try again after 6:00 PM.";
        }
    }
}
