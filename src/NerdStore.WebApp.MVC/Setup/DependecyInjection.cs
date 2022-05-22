using NerdStore.Core.Bus;

namespace NerdStore.WebApp.MVC.Setup;

public static class DependecyInjection
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IMediatrHandler, MediatrHandler>();
    }
}