using Projects.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Interfaces
{
    interface IUserService
    {
        bool Login();
        void Logout();

        User getCurrentuser();
    }
}
