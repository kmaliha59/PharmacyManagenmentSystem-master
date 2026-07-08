using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagenmentSystem
{
    internal class LoginProxy : ILoginServices
    {
        private readonly ILoginServices _loginService;
        private int _failedAttempts = 0;
        private const int MaxFailedAttempts = 3;

        public LoginProxy(ILoginServices loginService)
        {
            _loginService = loginService ?? throw new ArgumentNullException(nameof(loginService));
        }

        public bool Login(string username, string password)
        {
            if (_failedAttempts >= MaxFailedAttempts)
            {
                throw new UnauthorizedAccessException("Maximum login attempts exceeded.");
            }

            bool isAuthenticated = _loginService.Login(username, password);
            if (!isAuthenticated)
            {
                _failedAttempts++;
            }
            else
            {
                _failedAttempts = 0; // reset on successful login
            }

            return isAuthenticated;
        }
    }
}
