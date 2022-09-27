using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.DependencyInversion.DogruOrnek
{
    public class ExceptionReporter
    {
        private IDB dB;
        public ExceptionReporter(IDB _db)
        {
            dB =_db;
        }

        public void AddException(Exception exception)
        {
            dB.Add(exception);
        }
    }
}
