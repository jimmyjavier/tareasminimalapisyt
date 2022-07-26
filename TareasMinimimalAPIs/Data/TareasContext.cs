using Microsoft.EntityFrameworkCore;
using TareasMinimimalAPIs.Models;

namespace TareasMinimimalAPIs.Data;
public class TareasContext : DbContext
{
    public TareasContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Tarea> Tareas { get; set; }
}
