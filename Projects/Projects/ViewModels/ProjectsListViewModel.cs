using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Projects.Interfaces;
using Projects.Models;
using Projects.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;

namespace Projects.ViewModels
{
    public class ProjectsListViewModel : BindableBase
    {

        private ObservableCollection<ProjectListing> _ProjectsList { set; get; }
        public ObservableCollection<ProjectListing> ProjectsListTemp { set; get; }

        public DelegateCommand<int?> OpenDetails {get; private set;}


        CultureInfo culture = new CultureInfo("es-ES", false);


        private string _textSearch;

        public string Search
        {
            get
            {
                return _textSearch;
            }
            set
            {
                _textSearch = value;
                SearchEvent(_textSearch);
            }
        }
        INavigationService navigationService;
        public ProjectsListViewModel(INavigationService navService ,IProjectService projectservice)
        {
            IProjectService service = projectservice;

            _ProjectsList = new ObservableCollection<ProjectListing>(service.GetProjectListings());
            //List<Int32> copy = new List<Int32>(original);
            ProjectsListTemp = new ObservableCollection<ProjectListing>(_ProjectsList);

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

        private void SearchEvent(String textSearch)
        {
            if (string.IsNullOrWhiteSpace(textSearch))
                ProjectsListTemp = new ObservableCollection<ProjectListing>(_ProjectsList);
            else
                //Ignoring case better than change text to lowwer case or upper case
                ProjectsListTemp = new ObservableCollection<ProjectListing>(_ProjectsList.Where(i => culture.CompareInfo.IndexOf(i.ProjectName, textSearch, CompareOptions.IgnoreCase) >= 0));
        }

    }
	
}

