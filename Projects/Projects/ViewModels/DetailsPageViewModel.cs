using Prism.Commands;
using Prism.Mvvm;
using Projects.Interfaces;
using Projects.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Projects.ViewModels
{
	public class DetailsPageViewModel : BindableBase
	{
        public ObservableCollection<ProjectListing> Projects { get; set; }

        IProjectService ProjectService;

        public DetailsPageViewModel(IProjectService projectService)
        {
            ProjectService = projectService;
            Projects = new ObservableCollection<ProjectListing>(ProjectService.GetProjectListings());
        }
	}
}
