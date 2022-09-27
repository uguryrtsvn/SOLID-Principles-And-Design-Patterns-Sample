using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public interface IDatabaseFactory
    {
        Connection CreateConnection();
        Command CreateCommand();
    }
}
