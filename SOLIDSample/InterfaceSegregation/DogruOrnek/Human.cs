using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.InterfaceSegregation.DogruOrnek
{
    internal class Human : IWork, Iworker
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
            Console.WriteLine("İnsan Çalıştı.");
        }
    }
}
