using Projects.Interfaces;
using Projects.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projects.Services
{
    class ContactDetailsService : IContactDetailService
    {
        static ContactDetails data = new ContactDetails()
        {
            MobileNo = "01234567890",
            Email = "Test@email.com"
        };


        public ContactDetails getDetails()
        {
            return data;
        }
    }
}
