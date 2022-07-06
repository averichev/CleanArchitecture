using System.Threading.Tasks;
using UI.Contracts.View;

namespace UI.Contracts.Services
{
    public interface ICurrentSessionViewFactory
    {
        Task<ICurrentSessionView> BuildCurrentSessionView();
    }
}