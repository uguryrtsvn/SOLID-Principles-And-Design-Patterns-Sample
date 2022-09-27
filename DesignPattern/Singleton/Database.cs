using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    /*
     * Constructor priveate olmalı. Dışardan New Keywordü ile yenileneMEMEsi lazım.
     * 
     * Static bir değişken olmalı sınıfın instance referance ını tutabilmek için.
     * 
     * Instance a erişebilecek bir method olmalı örneğin getInstance()
     */
    class Database
    {
        private static Database instance;
        private static Object _lock = new Object(); // Bu objeyi lock() methodu içine verdiğimizde o scope u kilitler.
        private Database()
        { 
        } 
        public static Database getInstance()
        {
            if (instance == null)
            {
                lock (_lock) // Burada
                {
                    if (instance == null)
                    {
                        instance = new Database();
                    }
                }
            } 
            return instance;
        }

        public static void removeInstance()
        {
            if (instance!=null) instance = null;  
            GC.Collect();
        }
    }
}
