using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerServer.Logger.LogFile
{
    internal class FileHandler
    {
        private CheckForExistance oChecker;
        private CreateFile oCreater;
        private DeleteFile oDeleteFile;
        private WriteToFile oWriteToFile;

        public FileHandler()
        {
            oChecker = new CheckForExistance();
            oCreater = new CreateFile();
            oDeleteFile = new DeleteFile();
            oWriteToFile = new WriteToFile();
        }

        public void Startup()
        {

        }
    }
}
