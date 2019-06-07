using Prism;
using Prism.Ioc;
using Projects.Interfaces;
using Projects.Services;
using Projects.ViewModels;
using Projects.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Projects
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/ProjectDetails");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<DetailsPage, DetailsPageViewModel>();
            containerRegistry.RegisterForNavigation<ContactUs, ContactUsViewModel>();
            containerRegistry.Register<IProjectService,ProjectService>();
            containerRegistry.Register<IContactDetailService,ContactDetailsService>();
            containerRegistry.Register<IEmailService,EmailService>();
            containerRegistry.Register<IDialService,DialService>();
            containerRegistry.Register<ILocationService,LocationService>();
            containerRegistry.RegisterForNavigation<ProjectsList, ProjectsListViewModel>();
            containerRegistry.RegisterForNavigation<ProjectDetails, ProjectDetailsViewModel>();
        }
    }
}
