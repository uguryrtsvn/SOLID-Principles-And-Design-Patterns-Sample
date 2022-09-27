using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.OpenClosed.DogruOrnek
{
    internal class MSSql : IDataBase
    {
        public void AddDatabase(Employee employee)
        {
            Console.WriteLine("MSSQL ile eklendi.");
        }
    }
}
