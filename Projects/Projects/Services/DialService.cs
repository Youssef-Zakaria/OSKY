using Projects.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace Projects.Services
{
    public class DialService : IDialService
    {
        public void Dial(string number)
        {
            PhoneDialer.Open(number);
        }
    }
}
