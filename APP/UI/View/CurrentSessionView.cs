using UI.Contracts.Models;
using UI.Contracts.View;

namespace APP.UI.View
{
    public class CurrentSessionView : ICurrentSessionView
    {
        public CurrentSessionView(IServer server)
        {
            Server = server;
        }
        public IServer Server { get; }
    }
}