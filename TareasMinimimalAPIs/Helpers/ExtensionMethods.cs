using Microsoft.EntityFrameworkCore;
using TareasMinimimalAPIs.Data;

namespace TareasMinimimalAPIs.Helpers;
public static class ExtensionMethods
{

    public static async Task ConfigurarMigraciones(this WebApplication app)
    {
        var scope = app.Services.CreateScope();
        var services = scope.ServiceProvider;
        var loggerFactory = services.GetRequiredService<ILoggerFactory>();
        try
        {
            var context = services.GetRequiredService<TareasContext>();
            await context.Database.MigrateAsync();
            await ContextSeed.SeedAsync(context, loggerFactory);
        }
        catch (Exception exception)
        {
            var logger = loggerFactory.CreateLogger<Program>();
            logger.LogError(exception.Message);
            throw;
        }
    }

}
