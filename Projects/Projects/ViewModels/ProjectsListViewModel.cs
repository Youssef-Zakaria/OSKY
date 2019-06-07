using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Projects.Interfaces;
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
        public DelegateCommand<int?> OpenDetails {get; private set;}


        INavigationService navigationService;
        public ProjectsListViewModel(INavigationService navService ,IProjectService projectservice)
        {
            IProjectService service = projectservice;
            ProjectsList = new ObservableCollection<ProjectListing>(service.GetProjectListings());

            navigationService = navService;


            
            OpenDetails = new DelegateCommand<int?>(
                (id) => {

                if (!id.HasValue)
                    return;
                NavigationParameters navparams = new NavigationParameters();
                navparams.Add(NavParameterKeys.ProjectID,id);
                navigationService.NavigateAsync("ProjectDetails", navparams);                    

                }
                );

           
        }

    }
	
}

