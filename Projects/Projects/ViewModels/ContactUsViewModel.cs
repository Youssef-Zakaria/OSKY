using Prism.Commands;
using Prism.Mvvm;
using Projects.Interfaces;
using Projects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Projects.ViewModels
{
	public class ContactUsViewModel : BindableBase
	{
        IContactDetailService DetailService;
        IEmailService EmailService;
        IDialService DialService;
        ILocationService LocationService;

        public ContactDetails Contact { get; set; }
        public String Question { get; set; }
        public String Title { get; set; }


        Placemark _location;
        public Placemark Location { get => _location; set { _location = value; RaisePropertyChanged(); } }

        public DelegateCommand EmailCommand { get; private set; }
        public DelegateCommand DialCommand { get; private set; }
        public DelegateCommand QuestionCommand { get; private set; }

        public ContactUsViewModel(IContactDetailService detailService , IEmailService emailService , IDialService dialService , ILocationService locationService)
        {
            DetailService = detailService;
            EmailService = emailService;
            DialService = dialService;
            LocationService = locationService;
            Title = "Contact us";

            Contact = DetailService.getDetails();

            EmailCommand = new DelegateCommand(()=> {
                EmailService.sendEmail("Contact Us", "",Contact.Email);
            });

            DialCommand = new DelegateCommand(() => {
                DialService.Dial(Contact.MobileNo);
            });

            QuestionCommand = new DelegateCommand(() => {
                EmailService.sendEmail("Contact Us", Question, Contact.Email);
            });

            initPlacemark();
        }

        async Task initPlacemark ()
        {
            Location = await LocationService.getCurrentPlaceAsync();
        }
    }
}
