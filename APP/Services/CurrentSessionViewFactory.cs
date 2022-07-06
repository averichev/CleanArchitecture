using System.Threading.Tasks;
using APP.Contracts.Data;
using APP.UI.Models;
using APP.UI.View;
using UI.Contracts.Services;
using UI.Contracts.View;

namespace APP.Services
{
    public class CurrentSessionViewFactory : ICurrentSessionViewFactory
    {
        private readonly IApplicationInformation _applicationInformation;

        public CurrentSessionViewFactory(IApplicationInformation applicationInformation)
        {
            _applicationInformation = applicationInformation;
        }
        public async Task<ICurrentSessionView> BuildCurrentSessionView()
        {
            return new CurrentSessionView(new Server(_applicationInformation));
        }
    }
}