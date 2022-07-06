using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UI.Contracts.Services;
using UI.Contracts.View;

namespace UI.Controllers.API
{
    [ApiController]
    [Route("[controller]")]
    public class CurrentSessionController : ControllerBase
    {
        private readonly ICurrentSessionViewFactory _currentSessionViewFactory;
        private readonly ILogger<CurrentSessionController> _logger;

        public CurrentSessionController(
            ICurrentSessionViewFactory currentSessionService,
            ILogger<CurrentSessionController> logger
        )
        {
            _currentSessionViewFactory = currentSessionService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ICurrentSessionView> CurrentSessionInfo()
        {
            var view = await _currentSessionViewFactory.BuildCurrentSessionView();
            return view;
        }
    }
}