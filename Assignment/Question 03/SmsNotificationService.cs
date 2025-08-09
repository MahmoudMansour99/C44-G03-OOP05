using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Question_03
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string Receipt, string Message)
        {
            Console.WriteLine($"Sending SMS to {Receipt}: {Message}");
        }
    }
}
