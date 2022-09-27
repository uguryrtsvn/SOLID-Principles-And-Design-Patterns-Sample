using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory.DbOperation
{
    public class CustomDbOperation 
    {
        private readonly IDatabaseFactory databaseFactory;
        private readonly Connection _connection;
        private readonly Command _command;

        public CustomDbOperation(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
            _connection = databaseFactory.CreateConnection();
            _command = databaseFactory.CreateCommand();
        }

        public void removeById(int id)
        {
            _connection.OpenConnection();
            _command.ExecuteCommand("delete Users where userID =@id");
            _connection.CloseConnection();
        }



    }
}
