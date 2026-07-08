using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagenmentSystem
{
    // Target

    public interface IDatabaseAdapter
    {
        bool ValidateUser(string query);
        string Executecmd(string query);
        DataTable GetInDataTable(string query);
        List<string> GetInList(string query);
        string GetInText(string query);
    }
}
