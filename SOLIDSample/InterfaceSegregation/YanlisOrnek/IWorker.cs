using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.InterfaceSegregation.YanlisOrnek
{
    internal interface IWorker
    {
        void Eat();
        void Work();
        void Pay();
        void Rest();
    }
}
