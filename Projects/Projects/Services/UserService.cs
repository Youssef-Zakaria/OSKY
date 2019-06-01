using Projects.Interfaces;
using Projects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.Services
{
    public class UserService : IUserService
    {

        static List<User> registeredUsers = new List<User>() {
            new User() {Login = "Admin" , Password="123" }
        };





        public User getCurrentuser()
        {
            if (!GlobalProperties.isLoggedIn())
                return null;
            else return new User() { Login = GlobalProperties.Login, Password = GlobalProperties.Password };
        }
        
        public bool Login(string login, string password)
        {

            if (!registeredUsers.Any(user => user.Login == login && user.Password == password))
                return false;

            GlobalProperties.Login = login;
            GlobalProperties.Password = password;

            return true;
        }

        public void Logout()
        {
            GlobalProperties.Logout();
        }
    }
}
