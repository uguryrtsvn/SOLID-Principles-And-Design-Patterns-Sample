using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public abstract class Connection
    {
        public abstract bool OpenConnection();
        public abstract bool CloseConnection();
    }
}
