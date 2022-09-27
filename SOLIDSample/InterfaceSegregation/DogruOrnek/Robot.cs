using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.InterfaceSegregation.DogruOrnek
{
    internal class Robot : Iworker
    {
        public void Work()
        {
            Console.WriteLine("Robot Çalıştı");
        }
    }
}
