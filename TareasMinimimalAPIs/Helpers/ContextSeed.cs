using TareasMinimimalAPIs.Data;
using TareasMinimimalAPIs.Models;

namespace TareasMinimimalAPIs.Helpers;
public class ContextSeed
{
    public static async Task SeedAsync(TareasContext context, ILoggerFactory loggerFactory)
    {
        try
        {
            if (!context.Tareas.Any())
            {
                var tareas = new List<Tarea>()
                {
                    new Tarea
                    {
                        Nombre="Comprar Frutas y Verduras",
                        EsCompletado=false,
                        FechaCreacion=DateTime.UtcNow,
                        FechaModificacion=DateTime.UtcNow
                    },
                    new Tarea
                    {
                        Nombre="Comprar Pan XD",
                        EsCompletado=false,
                        FechaCreacion=DateTime.UtcNow,
                        FechaModificacion=DateTime.UtcNow
                    },
                    new Tarea
                    {
                        Nombre="Pagar Servicio de Agua",
                        EsCompletado=false,
                        FechaCreacion=DateTime.UtcNow,
                        FechaModificacion=DateTime.UtcNow
                    },
                    new Tarea
                    {
                        Nombre="Pagar Servicio de Luz",
                        EsCompletado=false,
                        FechaCreacion=DateTime.UtcNow,
                        FechaModificacion=DateTime.UtcNow
                    },
                    new Tarea
                    {
                        Nombre="Pagar Servicio de Internet",
                        EsCompletado=false,
                        FechaCreacion=DateTime.UtcNow,
                        FechaModificacion=DateTime.UtcNow
                    }
                };

                await context.Tareas.AddRangeAsync(tareas);
                await context.SaveChangesAsync();
            }
        }
        catch (Exception ex)
        {
            var logger = loggerFactory.CreateLogger<ContextSeed>();
            logger.LogError(ex.Message);
        }
    }
}
