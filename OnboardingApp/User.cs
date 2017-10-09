using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingApp
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAccountOwner { get; set; }
        public string PinNumber { get; set; }
        public string AccountNumber { get; set; }
        public string Email { get; set; }
        public AccountType AType { get; set; }
    }

    public enum AccountType
    {
        Checking,
        Savings,
        Business,
    }
}
