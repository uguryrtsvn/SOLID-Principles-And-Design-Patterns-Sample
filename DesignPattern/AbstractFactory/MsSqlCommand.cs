using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    public class MsSqlCommand : Command
    {
        public override void ExecuteCommand(string query)
        {
            Console.WriteLine("MsSql Server ExecuteCommand Çalıştı.");
        }
    }
}
