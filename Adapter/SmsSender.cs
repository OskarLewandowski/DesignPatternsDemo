using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    //this class simulate, class from other implementation, nuget package 
    public class SmsSender
    {
        public void SendSms(string to, string text)
        {
            Console.WriteLine($"Sending SMS to: {to}\n{text}");
        }
    }
}
