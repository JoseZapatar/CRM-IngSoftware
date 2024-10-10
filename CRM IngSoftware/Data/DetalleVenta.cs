public class DetalleVenta
{
    public int ID_Detalle_Venta { get; set; }
    public int ID_Venta { get; set; }
    public int ID_Producto { get; set; }
    public int Cantidad { get; set; }
    public decimal Precio_Unitario { get; set; }
}
