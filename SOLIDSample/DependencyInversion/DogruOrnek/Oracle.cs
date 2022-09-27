using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.DependencyInversion.DogruOrnek
{
    internal class Oracle : IDB
    {
        public void Add(Exception exception)
        {
            Console.WriteLine("Hata Oracle ile aktarıldı.");
        }
    }
}
