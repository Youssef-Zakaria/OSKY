using Projects.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Interfaces
{
    interface IUserService
    {
        bool Login(String login, String password);
        void Logout();

        User getCurrentuser();
    }
}
