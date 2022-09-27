using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.LiskovsSubstitution.DogruOrnek
{
    internal class DatabaseLog : DatabaseConnected
    {
        public override void ColoseConnect()
        {
            Console.WriteLine("Bağlantı Kapandı.");
        }

        public override void OpenConnect()
        {
            Console.WriteLine("Bağlantı Açıldı.");
        }

        public override void WriteLog(string content)
        {
            Console.WriteLine("Log Database e kaydedildi.");
        }
    }
}
