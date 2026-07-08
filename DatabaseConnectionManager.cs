using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagenmentSystem
{
    public class DatabaseConnectionManager
    {
        private static DatabaseConnectionManager _instance;
        private static readonly object _lock = new object();
        private SqlConnection _connection;

        // Private constructor to prevent instantiation from outside
        private DatabaseConnectionManager()
        {
            // Initialize the connection
            _connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS01;Initial Catalog=PharmacyManagmentSystem;Integrated Security=True");
        }

        // Public method to provide access to the instance
        public static DatabaseConnectionManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseConnectionManager();
                    }
                    return _instance;
                }
            }
        }

        // Method to get the connection
        public SqlConnection GetConnection()
        {
            return _connection;
        }

        // Optional: Method to open the connection
        public void OpenConnection()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        // Optional: Method to close the connection
        public void CloseConnection()
        {
            if (_connection.State != ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        //private static DatabaseConnectionManager _instance;
        //private static readonly object _lock = new object();
        //private SqlConnection _connection;

        //// Private constructor to prevent instantiation from outside
        //private DatabaseConnectionManager()
        //{
        //    // Initialize the connection
        //    _connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS01;Initial Catalog=PharmacyManagmentSystem;Integrated Security=True");
        //}

        //// Public method to provide access to the instance
        //public static DatabaseConnectionManager Instance
        //{
        //    get
        //    {
        //        lock (_lock)
        //        {
        //            if (_instance == null)
        //            {
        //                _instance = new DatabaseConnectionManager();
        //            }
        //            return _instance;
        //        }
        //    }
        //}

        //// Method to get the connection
        //public SqlConnection GetConnection()
        //{
        //    return _connection;
        //}

        //// Optional: Method to open the connection
        //public void OpenConnection()
        //{
        //    if (_connection.State != ConnectionState.Open)
        //    {
        //        _connection.Open();
        //    }
        //}

        //// Optional: Method to close the connection
        //public void CloseConnection()
        //{
        //    if (_connection.State != ConnectionState.Closed)
        //    {
        //        _connection.Close();
        //    }
        //}
    }
}
