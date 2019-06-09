using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using Projects.Models;
using Projects.Services;
using Projects.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace Projects.ViewModels
{
	public class UserLoginPageViewModel : BindableBase
    {
        IPageDialogService DialogService;

        protected INavigationService NavigationService { get; set; }
        public ICommand OnLoginClicked { get; set; }
        public UserService userService { get; set; }



        //public DelegateCommand Login { get; private set; }


        public UserLoginPageViewModel(INavigationService navigationService, IPageDialogService _dialogService)
        {
            DialogService = _dialogService;
            NavigationService = navigationService;
            userService = new UserService();
            OnLoginClicked = new DelegateCommand(Login_Clicked);
        }

        private string _userName;

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                 SetProperty(ref _userName, value); 
            }
        }

        private string _password;

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                SetProperty(ref _password, value);
            }
        }

        private void Login_Clicked()
        {
            if (userService.Login(UserName, Password))
                NavigationService.NavigateAsync("ProjectsList");
            else
                DialogService.DisplayAlertAsync("Alert", "User Name or Password might be incorrect !", "OK");

            Password = "";
            UserName = "";
        }
    }
}
