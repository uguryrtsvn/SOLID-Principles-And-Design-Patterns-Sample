using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.InterfaceSegregation.YanlisOrnek
{
    internal class Robot : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Pay()
        {
            throw new NotImplementedException();
        }

        public void Rest()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            Console.WriteLine("Robot Çalıştı.");
        }

        // Diğer methodlarıda iplemente etmesi kötü bir durum.
        // Bu yüzden ayrıştırmak gerekli. Ortak olanlar bir arada tutulur.
    }
}
