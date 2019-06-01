using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        public DelegateCommand NavigateCommand { private set; get; }


        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            NavigateCommand = new DelegateCommand(() => {
                NavigationService.NavigateAsync("DetailsPage");
            });
        }
    }
}
