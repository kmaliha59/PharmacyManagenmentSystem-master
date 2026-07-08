using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace PharmacyManagenmentSystem
{
    // Adapter
    public class DatabaseAdapter : IDatabaseAdapter
    {
        private DatabaseOperation dbOperation;

        public DatabaseAdapter()
        {
            dbOperation = new DatabaseOperation();
        }

        public bool ValidateUser(string query)
        {
            return dbOperation.Validation(query);
        }

        public string Executecmd(string query)
        {
            return dbOperation.Execution(query);
        }

        public DataTable GetInDataTable(string query)
        {
            return dbOperation.SearchDataTable(query);
        }

        public List<string> GetInList(string query)
        {
            return dbOperation.SearchList(query);
        }

        public string GetInText(string query)
        {
            return dbOperation.SearchText(query);
        }

        //private DatabaseOperation dbOperation;

        //public DatabaseAdapter()
        //{
        //    dbOperation = new DatabaseOperation();
        //}
        //public bool ValidateUser(string query)
        //{
        //    return dbOperation.Validation(query);
        //}

        //public string Executecmd(string query)
        //{ 

        //    return dbOperation.Execution(query);

        //}

        //public DataTable GetInDataTable(string query)
        //{
        //    return dbOperation.SearchDataTable(query);
        //}

        //public List<string> GetInList(string query)
        //{
        //    return dbOperation.SearchList(query);
        //}

        //public string GetInText(string query)
        //{
        //    return dbOperation.SearchText(query);
        //}

    }
}
