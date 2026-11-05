using OmriApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmriApp.Services
{
    internal class DBMokup
    {

        private List<AppUser> _users = new List<AppUser>();
        public DBMokup()
        {
            _users.Add(new AppUser { Email = "admin@mail.com", UserPassword = "admin" });
            _users.Add(new AppUser { Email = "user1@mail.com", UserPassword = "pass1" });
            _users.Add(new AppUser { Email = "user2@mail.com", UserPassword = "pass2" });
        }
        public bool isExist(string uEmail, string uPass)
        {
            return _users.Any(u => u.Email == uEmail && u.UserPassword == uPass);
        }
    }
}
