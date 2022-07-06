using UI.Contracts.Models;

namespace UI.Contracts.View
{
    public interface ICurrentSessionView
    {
        public IServer Server { get; }
    }
}