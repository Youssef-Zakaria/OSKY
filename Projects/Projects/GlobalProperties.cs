using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Projects
{
    public class GlobalProperties
    {
        public String Login
        {
            get => App.Current.Properties["Login"].ToString();
            set
            {
                App.Current.Properties["Login"] = value;
            }
        }


        public String Password
        {
            get => App.Current.Properties["Password"].ToString();
            set
            {
                App.Current.Properties["Password"] = value;
            }
        }
    }
}
