using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class MsSqlConnection : Connection
    {
        public override bool CloseConnection()
        {
            Console.WriteLine("MsSql Bağlantı Açıldı");
            return true;
        }

        public override bool OpenConnection()
        {
            Console.WriteLine("MsSql Bağlantı Kapandı");
            return true;
        }
    }
}
