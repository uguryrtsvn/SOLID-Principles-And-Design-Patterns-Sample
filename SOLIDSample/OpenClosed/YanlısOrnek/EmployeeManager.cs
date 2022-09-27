using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.OpenClosed.YanlısOrnek
{
    public class EmployeeManager
    {
        public void AddDataBase(object obj, Employee employee)
        {
            if (obj.GetType().ToString() == "Oracle")
            {
                OracleDB oracleDB = new OracleDB();
                oracleDB.Add(employee);
            }
            else if (obj.GetType().ToString() == "SQL")
            {
                SqlDB oracleDB = new SqlDB();
                oracleDB.Add(employee);
            }
            // Yanlış olmasının sebebi bir çok database geldiğinde 7-8 çeşit
            // burası bir okadar İF ELSE ile dolacak
        }
    }
}
