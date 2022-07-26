namespace TareasMinimimalAPIs.Models;
public class Tarea
{
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public bool EsCompletado { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }

}
