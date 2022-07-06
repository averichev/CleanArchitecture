using System;
using APP.Contracts.Data;
using UI.Contracts.Models;

namespace APP.UI.Models
{
    public class Server : IServer
    {
        public Server(IApplicationInformation applicationInformation)
        {
            Time = applicationInformation.CurrentTime;
        }

        public DateTime Time { get; }
    }
}