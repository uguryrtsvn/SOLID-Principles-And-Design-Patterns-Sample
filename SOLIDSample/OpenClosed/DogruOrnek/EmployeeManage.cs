using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.OpenClosed.DogruOrnek
{
    internal class EmployeeManage
    {  
        public void AddDB(IDataBase db,Employee employee) {
            db.AddDatabase(employee);
        }
    }
}
