using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.LiskovsSubstitution.YanlisOrnek
{
    public class DatabaseLogger : Logger
    {
        public override void CloseConnection()
        {
            Console.WriteLine("Database Bağlantı Kapandı.");
        }

        public override void Log()
        {
            Console.WriteLine("İçeriği Database e aktardı.");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Database Bağlantı Açıldı.");
        }
    }
}
