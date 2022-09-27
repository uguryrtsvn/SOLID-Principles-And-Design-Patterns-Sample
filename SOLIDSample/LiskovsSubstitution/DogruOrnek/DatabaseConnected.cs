using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDSample.LiskovsSubstitution.DogruOrnek
{
    abstract class DatabaseConnected : Log
    {
        public abstract void OpenConnect();
        public abstract void ColoseConnect();

        // Diğer sınıflar tarafından kullanılmayan methodlar kalıyorsa. Bu şekilde ayrıştırıp
        // Sınıfları hangi abstract sınıftan türemesi gerekiyorsa ondan inherit ediyoruz ki,
        // başka durumlar için yazılmış methodlar o sınıfta boş kalmasın.
    }
}
