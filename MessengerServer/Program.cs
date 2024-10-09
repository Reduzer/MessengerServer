using MessengerServer.Logger;
using System;
using System.Threading;

namespace Server
{
    public static class Server
    {
        public static void Main()
        {
            Logger.Instance.StartUp();
        }
    }
}
