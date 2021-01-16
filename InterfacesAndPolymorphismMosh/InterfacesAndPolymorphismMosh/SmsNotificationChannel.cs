using System;

namespace InterfacesAndPolymorphismMosh
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending Sms....");
        }
    }
}
