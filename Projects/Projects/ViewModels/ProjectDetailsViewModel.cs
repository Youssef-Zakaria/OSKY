using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Projects.Interfaces;
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
        IProjectService _ProjectService;
        public Project project { get; set; }
        public ICommand OnbtnClicked { get; set; }
        public ProjectDetailsViewModel(INavigationService navigationService , IProjectService ProjectService)
        {
            _ProjectService = ProjectService;
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
            project = this._ProjectService.GetProject(projectID);
        }
    }
}
