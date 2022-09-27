using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.LiskovsSubstitution.DogruOrnek
{
    internal class FileLog : Log
    {
        public override void WriteLog(string content)
        {
            Console.WriteLine("Log dosyaya aktarıldı.");
        }
    }
}
