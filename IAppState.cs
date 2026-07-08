using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagenmentSystem
{
    // State interface
    public interface IAppState
    {
        bool GetState();
        string ProcessAction();
    }
}
