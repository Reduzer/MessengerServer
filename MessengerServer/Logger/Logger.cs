using MessengerServer.Logger.LogFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerServer.Logger
{
    public class Logger
    {
        private static Logger LoggerInstance;
        private FileHandler fileHandler;

        private Logger() 
        {
            fileHandler = new FileHandler();
        }

        public static Logger Instance {

            get
            {
                if (LoggerInstance == null)
                {
                    LoggerInstance = new Logger();
                    return LoggerInstance;
                }
                else
                {
                    return LoggerInstance;
                }
            }  
        }

        public void Write(string message)
        {

        }

        public void StartUp()
        {
            fileHandler.Startup();
        }
    }
}
