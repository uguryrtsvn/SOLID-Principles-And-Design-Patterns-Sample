using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.DependencyInversion.DogruOrnek
{
    internal class Mongo : IDB
    {
        public void Add(Exception exception)
        {
            Console.WriteLine("Hata Mongo ile aktarıldı.");
        }
    }
}
