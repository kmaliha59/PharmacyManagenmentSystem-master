using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagenmentSystem
{
    // Context class
    public class AppContext
    {
        private IAppState currentState;

        public AppContext()
        {
            currentState = GetCurrentState();
        }

        private IAppState GetCurrentState()
        {
            DateTime currentTime = DateTime.Now;
            int lockStartHour = 00; // 12:00 AM (noon)
            int lockEndHour = 06;   // 6:00 AM

            if (currentTime.Hour <= lockStartHour && currentTime.Hour > lockEndHour)
            {
                return new LockedState();
            }
            else
            {
                return new UnlockedState();
            }
        }

        public bool GetState()
        {
            return currentState.GetState();
        }
        public string ProcessAction()
        {
            return currentState.ProcessAction();
        }
    }
}
