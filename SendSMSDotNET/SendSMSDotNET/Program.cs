using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nexmo.Api;
namespace SendSMSDotNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the text you want to send: ");
            string text = Console.ReadLine();
            var results = SMS.Send(new SMS.SMSRequest
            {
                from = "",
                to = "",
                text = text
            });
        }
    }
}
