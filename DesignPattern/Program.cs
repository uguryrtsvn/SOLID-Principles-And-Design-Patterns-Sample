using DesignPattern.AbstractFactory;
using DesignPattern.AbstractFactory.DbOperation;
using DesignPattern.FactoryPattern;
using DesignPattern.Singleton;
using System;
using System.Threading;

namespace DesignPatterns
{
    internal class Program
    {
        /*
         * Creational Patterns
         * 
         *      1- Singleton Pattern (Tek bir nesne alıp uygulamanın life time ı boyunca bu nesne üzerinden işlem yapmamızı sağlar.)
         *      2- Factory (Hangi servisin kullanılacağına karar vermeyi sağlar.)
         *      3- Abstract Factory
         *      4-Builder 
         *      5- ProtoType
         * 
         * 
         * Structral Patterns
         * 
         *      1- Bridge
         *      2- Adapter
         *      3- Composite 
         *      4- Decorator
         *      5- Facade
         *      6- Fylweight
         *      7- Proxy
         * 
         * Behavioral Patterns
         * 
         *      1- Chain of Responsibility    ***** Öncelikli
         *      2- Command 
         *      3- InterPreter
         *      4- Iterator
         *      5- Mediator   ***** Öncelikli
         *      6- Observer   ***** Öncelikli
         *      7- Visitor
         */
        static void Main(string[] args)
        {
            #region Singletion

            //Console.WriteLine("Hello World!");

            //Database database = Database.getInstance();

            //Thread.Sleep(2000);

            //Database db = Database.getInstance();

            //Console.WriteLine(db == database);

            //Database.removeInstance();

            //Database qwe = Database.getInstance();
            ///Console.WriteLine(qwe == db);
            #endregion 
            #region FactoryPattern

            NotifyFactory notifyFactory = new NotifyFactory();

            INotify notify = notifyFactory.CreateNotification(NotifyType.Email);

            notify.SendNotification(new User());


            //INotify notify2 = notifyFactory.CreateNotification(NotifyType.Sms);

            //notify2.SendNotification(new User());

            //Console.WriteLine(notifyFactory.GetType().Name);


            #endregion

            #region Abstract Factory Pattern

            CustomDbOperation OracleDbOperation = new CustomDbOperation(new OracleDatabaseFactory());
            CustomDbOperation SqlDbOperation = new CustomDbOperation(new MsSqlDatabaseFactory());
 
            OracleDbOperation.removeById(3);
            Console.WriteLine(new String(Convert.ToChar(2),100));
            SqlDbOperation.removeById(4);

            #endregion

        }
    }
}
