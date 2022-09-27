using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class OracleConnection : Connection
    {
        public override bool CloseConnection()
        {
            Console.WriteLine("Oracle Bağlantı Kapandı");
            return true;
        }

        public override bool OpenConnection()
        {
            Console.WriteLine("Oracle Bağlantı Açıldı");
            return true;
        }
    }
}
