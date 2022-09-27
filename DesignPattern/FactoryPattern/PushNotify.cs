using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    internal class PushNotify : INotify
    {
        public void SendNotification(User user)
        {
            Console.WriteLine("Push Gönderildi.");
        }
    }
}
