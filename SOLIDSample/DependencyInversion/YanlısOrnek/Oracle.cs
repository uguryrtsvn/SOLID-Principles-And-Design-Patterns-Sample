using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.DependencyInversion.YanlısOrnek
{
    public class Oracle
    {
        public void Add(Object obj)
        {
            Console.WriteLine("Add value to database Oracle");
        }
    }
}
