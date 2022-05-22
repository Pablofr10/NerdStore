using NerdStore.Catalogo.Data;
using NerdStore.Catalogo.Data.Repository;
using NerdStore.Catalogo.Domain;
using NerdStore.Core.Bus;

namespace NerdStore.WebApp.MVC.Setup;

public static class DependecyInjection
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IMediatrHandler, MediatrHandler>();

        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        services.AddScoped<IEstoqueService, EstoqueService>();
        services.AddScoped<CatalogoContext>();

    }
}