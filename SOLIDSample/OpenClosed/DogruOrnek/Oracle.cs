using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.OpenClosed.DogruOrnek
{
    internal class Oracle : IDataBase
    {
        public void AddDatabase(Employee employee)
        {
            Console.WriteLine("Oracle a eklendi");
        }
    }
}
