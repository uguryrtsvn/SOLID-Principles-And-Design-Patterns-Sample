using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.InterfaceSegregation.YanlisOrnek
{
    internal class Human : IWorker
    {
        public void Eat()
        {
            Console.WriteLine("İnsan Yedi");
        }

        public void Pay()
        {
            Console.WriteLine("İnsan Ödeme");
        }

        public void Rest()
        {
            Console.WriteLine("İnsan Dinlenme");
        }

        public void Work()
        {
            Console.WriteLine("İnsan Çalışma");
        }
    }
}
