using APP.Contracts.Data;
using APP.Services;
using DMN.Logic.Application;
using Microsoft.Extensions.DependencyInjection;
using UI.Contracts.Services;

namespace CompositionRoot
{
    public class ServiceConfigurator
    {
        private static IServiceCollection _serviceCollection;

        public static void Init(IServiceCollection serviceCollection)
        {
            _serviceCollection = serviceCollection;
        }

        public static void AddServices()
        {
            _serviceCollection.AddTransient<ICurrentSessionViewFactory, CurrentSessionViewFactory>();
            _serviceCollection.AddTransient<IApplicationInformation, ApplicationInformation>();
        }
    }
}