using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Projects
{
    public static class GlobalProperties
    {
        public static String Login
        {
            get => App.Current.Properties["Login"].ToString();
            set
            {
                App.Current.Properties["Login"] = value;
                App.Current.SavePropertiesAsync();
            }
        }


        public static String Password
        {
            get => App.Current.Properties["Password"].ToString();
            set
            {
                App.Current.Properties["Password"] = value;
                App.Current.SavePropertiesAsync();
            }
        }

        public static void Logout() {
            App.Current.Properties.Keys.Clear();            
        }

        public static bool isLoggedIn()
        {
            return App.Current.Properties.ContainsKey("Login") && App.Current.Properties.ContainsKey("Password");
        }


    }
}
