using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;


namespace Projects.Interfaces
{
    public interface IEmailService
    {
        void sendEmail(String subject, String body, String recipients);
    }
}
