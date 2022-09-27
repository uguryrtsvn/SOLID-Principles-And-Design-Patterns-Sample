using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class MsSqlDatabaseFactory : IDatabaseFactory
    {
        public Command CreateCommand()
        {
            return new MsSqlCommand();
        }

        public Connection CreateConnection()
        {
            return new MsSqlConnection();
        }
    }
}
