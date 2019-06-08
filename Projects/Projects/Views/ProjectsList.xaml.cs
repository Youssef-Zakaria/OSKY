using Prism.Navigation;
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
            
        }
        

        protected override void OnSizeAllocated(double width, double height)
        {
            //To Make Image take full width
            base.OnSizeAllocated(width, height);
            imgbg.WidthRequest = width;
            imgbg.HeightRequest = 191.0;
        }

        public void lvItemTapped(object sender, ItemTappedEventArgs e) {
            var myListView = (ListView)sender;
            var myItem = myListView.SelectedItem as ProjectListing;
            
            ((ProjectsListViewModel)this.BindingContext).OpenDetails.Execute(myItem.ID);            
        }
    }
}
