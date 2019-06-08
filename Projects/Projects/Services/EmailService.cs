using Projects.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace Projects.Services
{
    public class EmailService : IEmailService
    {
        public void sendEmail(string subject, string body, string recipients)
        {
            EmailMessage message = new EmailMessage(subject, body, recipients);
            Email.ComposeAsync(message);
        }
    }
}
