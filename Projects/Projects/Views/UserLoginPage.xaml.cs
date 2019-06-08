using System;
using Xamarin.Forms;

namespace Projects.Views
{
    public partial class UserLoginPage : ContentPage
    {

        public UserLoginPage()
        {
            InitializeComponent();
        }

        private void TxtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblUserName.IsVisible = true;
        }

        private void TxtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblPassword.IsVisible = true;
        }


        private void BtnShowHide_Clicked(object sender, EventArgs e)
        {
            txtPassword.IsPassword = !txtPassword.IsPassword;
            if (txtPassword.IsPassword)
                btnShowHide.Text = "Show Password";
            else
                btnShowHide.Text = "Hide Password";

        }
    }
}
