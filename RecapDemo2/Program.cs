using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Log = new SmsLogger();
            customerManager.Add();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        public ILog Log { get; set; }

        public void Add()
        {
            Log.Log();
            Console.WriteLine("Customer Added.");
        }
    }
    class DataBaseLogger : ILog
    {
        public void Log()
        {
            Console.WriteLine("Database Logged");
        }
    }
    class FileLogger : ILog
    {
        public void Log()
        {
            Console.WriteLine("File Logged");
        }
    }
    class SmsLogger : ILog
    {
        public void Log()
        {
            Console.WriteLine("SMS Logged");
        }
    }
    interface ILog
    {
        void Log();
    }
}
