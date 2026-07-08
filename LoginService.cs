using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagenmentSystem
{
    internal class LoginService:ILoginServices
    {
        private readonly IDatabaseAdapter _dbAdapter;

        public LoginService(IDatabaseAdapter dbAdapter)
        {
            _dbAdapter = dbAdapter ?? throw new ArgumentNullException(nameof(dbAdapter));
        }

        public bool Login(string username, string password)
        {
            string userQuery = $"Select * from Users where UserName = '{username}' AND password = '{password}'";
            string managerQuery = $"Select * from Manager where ManagerName = '{username}' AND password = '{password}'";

            return _dbAdapter.ValidateUser(userQuery) || _dbAdapter.ValidateUser(managerQuery);
        }
    }
}
