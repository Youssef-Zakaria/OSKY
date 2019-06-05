using Projects.Models;
using Projects.Services;
using Projects.ViewModels;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace Projects.Views
{
    public partial class ProjectsList : ContentPage
    {
        public ProjectsList()
        {
            InitializeComponent();
            BindingContext = new ProjectsListViewModel();
        }



        CultureInfo culture = new CultureInfo("es-ES", false);


        void Search(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            var _container = BindingContext as ProjectsListViewModel;
            ProjectListView.BeginRefresh();


            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                ProjectListView.ItemsSource = _container.ProjectsList;
            else
                //Comparing between the input and Projects Name Ignoring The case Sensitive
                ProjectListView.ItemsSource = new ObservableCollection<ProjectListing>(_container.ProjectsList.Where(i => culture.CompareInfo.IndexOf(i.ProjectName, e.NewTextValue, CompareOptions.IgnoreCase) >= 0));
            
            ProjectListView.EndRefresh();
        }


        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var _container = BindingContext as ProjectsListViewModel;
            //do work over here
            DisplayAlert("Sucess", "You have Subscribed", "OK", "Cancel");
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            //To Make Image take full width
            base.OnSizeAllocated(width, height);
            imgbg.WidthRequest = width;
            imgbg.HeightRequest = 191.0;
        }

        public async void lvItemTapped(object sender, ItemTappedEventArgs e) {
            var myListView = (ListView)sender;
            var myItem = myListView.SelectedItem as ProjectListing;
            await Navigation.PushModalAsync(new DetailsPage(/*myItem.ID*/) );
            
        }
    }
}
