namespace Biblioteca;
public class ItemVenta
{
    public string NombreProducto { get; set; }
    public string PrecioUnitario { get; set; }
    public string CantidadVendida { get; set; }
    public decimal SubtotalItem { get; set; }
    public decimal PrecioTotal { get; set; }

public ItemVenta(string nombreProducto, string precioUnitario, string cantidadVendida, decimal subtotalItem, decimal precioTotal)
    {
        NombreProducto = nombreProducto;
        PrecioUnitario = precioUnitario;
        CantidadVendida = cantidadVendida;
        SubtotalItem = subtotalItem;
        PrecioTotal = precioTotal;
    }
}