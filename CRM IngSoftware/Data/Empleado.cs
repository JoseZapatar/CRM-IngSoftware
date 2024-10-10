using System;

public class Empleado
{
    public int ID_Empleado { get; set; }
    public string Nombre_Empleado { get; set; }
    public string Correo_Empleado { get; set; }
    public string Contraseña { get; set; }
    public bool EsAdministrador { get; set; }
    public DateTime Fecha_Registro { get; set; }
}
