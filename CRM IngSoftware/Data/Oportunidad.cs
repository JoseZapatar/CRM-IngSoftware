using System;

public class Oportunidad
{
    public int ID_Oportunidad { get; set; }
    public int ID_Cliente { get; set; }
    public string Descripcion { get; set; }
    public string Estado { get; set; } // "Activa", "Cerrada", o "Perdida"
    public DateTime Fecha_Creacion { get; set; }
    public DateTime? Fecha_Cierre { get; set; } // Puede ser nulo si la oportunidad está "Activa"

    // Constructor opcional para inicializar la oportunidad
    public Oportunidad(int idOportunidad, int idCliente, string descripcion, string estado, DateTime fechaCreacion, DateTime? fechaCierre = null)
    {
        ID_Oportunidad = idOportunidad;
        ID_Cliente = idCliente;
        Descripcion = descripcion;
        Estado = estado;
        Fecha_Creacion = fechaCreacion;
        Fecha_Cierre = fechaCierre;
    }

    // Constructor vacío por conveniencia
    public Oportunidad() { }
}
