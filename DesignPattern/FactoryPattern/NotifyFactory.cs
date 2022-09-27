using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    public enum NotifyType
    {
        Email = 1,
        Sms,
        Push
    }
    internal class NotifyFactory
    {
        public INotify CreateNotification(NotifyType notifyType)
        {
            Console.WriteLine(notifyType.GetTypeCode());
            Console.WriteLine(notifyType.GetType().ReflectedType);

            if (notifyType == NotifyType.Email)
            {
                return new MailNotify();
            }
            else if (notifyType == NotifyType.Sms)
            {
                return new SmsNotify();
            }
            else
            {
                return new PushNotify(); 
            }
        }
    }
}
