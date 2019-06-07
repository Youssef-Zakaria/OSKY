using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Projects.Models;
using Projects.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Projects.ViewModels
{
    public class ProjectsListViewModel : BindableBase
    {
        public ObservableCollection<ProjectListing> ProjectsList { set; get; }
        INavigationService _navigationService { get; set; }
        public ProjectsListViewModel(INavigationService navigationService)
        {
            ProjectService service = new ProjectService();
            ProjectsList = new ObservableCollection<ProjectListing>(service.GetProjectListings());
            _navigationService = navigationService;
        }

        public async System.Threading.Tasks.Task NavigateToDeailsAsync(int id)
        {
            var navigationParams = new NavigationParameters();
            navigationParams.Add("ID", id);
            await _navigationService.NavigateAsync("ProjectDetails", navigationParams);
        }

    }

}

