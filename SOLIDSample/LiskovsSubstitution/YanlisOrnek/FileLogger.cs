using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.LiskovsSubstitution.YanlisOrnek
{
    internal class FileLogger : Logger
    {
        public override void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public override void Log()
        {
            Console.WriteLine("İçeriği Dosyaya aktardı.");
        }

        public override void OpenConnection()
        {
            throw new NotImplementedException();
        }
    }
}
