using SOLIDSample.DependencyInversion.DogruOrnek;
using SOLIDSample.OpenClosed;
using SOLIDSample.OpenClosed.DogruOrnek;
using System;

namespace SOLIDSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Open/Closed Prensibi
            //IDataBase _dataBase = new MSSql();

            //Employee employee = new Employee();

            //EmployeeManage employeeManage = new EmployeeManage();

            //employeeManage.AddDB(_dataBase, employee); 

            //IDataBase _db = new Oracle();

            //Employee emp = new Employee();

            //employeeManage.AddDB(_db, emp);
            #endregion

            #region DependencyInversion

            IDB dB = new Mongo(); 
            ExceptionReporter exceptionRep = new ExceptionReporter(dB);
            exceptionRep.AddException(new Exception());



            IDB dB2 = new MsSql(); 
            ExceptionReporter exceptionRep2 = new ExceptionReporter(dB2);
            exceptionRep2.AddException(new Exception()); 

            #endregion


        }
    }
}
