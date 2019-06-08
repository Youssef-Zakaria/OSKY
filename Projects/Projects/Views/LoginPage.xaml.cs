using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projects.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        int counter = 0;

        public LoginPage ()
		{
			InitializeComponent ();
		}

        private void Login_Clicked(object sender, EventArgs e)
        {
            if (RememberMe.IsToggled)
            {
                counter = 1;
            }
        }
    }
}