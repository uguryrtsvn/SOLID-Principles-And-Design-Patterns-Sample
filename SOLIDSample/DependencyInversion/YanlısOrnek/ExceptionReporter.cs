using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.DependencyInversion.YanlısOrnek
{
    public class ExceptionReporter
    {
        private Oracle oracle;
        public ExceptionReporter(Oracle _oracle)
        {
            oracle = _oracle;
        }
        public void ReportException(Exception ex)
        {
            oracle.Add(ex);
        }

// Buradaki DATABASE sınıfı değiştiğinde burada karar yapısı(İF ELSE) kurmak gerekicek.
// buda istenmeyen bir durum. Bu durumdan kurtulmak için Open/Close ile beraber Dependency Inversion kullanılacak.
    }
}
