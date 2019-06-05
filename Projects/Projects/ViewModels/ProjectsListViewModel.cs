using Prism.Commands;
using Prism.Mvvm;
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

        public ProjectsListViewModel()
        {
            ProjectService service = new ProjectService();
            ProjectsList = new ObservableCollection<ProjectListing>(service.GetProjectListings());
        }

    }
	
}

