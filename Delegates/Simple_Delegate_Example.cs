using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void LogHandler(string message);

    public class Logger
    {
        public void LogToConsole(string message)
        {
            Console.WriteLine("Console Log: "+message );
        }

        public void LogToFile(string message)
        {
            Console.WriteLine("File log: "+ message );  
        }
    }
    internal class Simple_Delegate_Example
    {
        public void example()
        {
            Logger logger = new Logger();

            LogHandler logHandler = logger.LogToConsole;
            //multi cast deligate
            logHandler += logger.LogToFile;

            logHandler("Log info info!");

            logHandler -= logger.LogToFile;

            logHandler("Log info info!");
        }
    }
}
