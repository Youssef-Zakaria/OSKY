using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Projects.Models;
using Projects.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projects.ViewModels
{
    public class ProjectDetailsViewModel : BindableBase, INavigatedAware, INotifyPropertyChanged
    {
        protected INavigationService NavigationService { get; set; }
        public int projectID { get; set; }
        public Project project { get; set; }
        public ProjectService propServe { get; set; }
        public ICommand OnbtnClicked { get; set; }
        public ProjectDetailsViewModel(INavigationService navigationService)
        {
            propServe = new ProjectService();
            NavigationService = navigationService;
            OnbtnClicked = new DelegateCommand(onContactsCliked);
        }

        private void onContactsCliked()
        {

            NavigationService.NavigateAsync("ContactUs");

        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            projectID = parameters.GetValue<int>("ID");
            project = this.propServe.GetProject(projectID);
        }
    }
}
