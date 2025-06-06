namespace Biblioteca;

public class Electrodomestico
{
    public string Nombre {get; set;}
    public string CodigoAlfaNumerico {get; set;}
    public string Descripcion {get; set;}
    public int Stock {get; set;}
    public decimal PrecioUnitario {get; set;} 
    public Electrodomestico(string nombre, string codigoAlfaNumerico, string descripcion, int stock, decimal precioUnitario)
    {
        if (string.IsNullOrWhiteSpace(nombre))
        {
            throw new ArgumentException("El nombre no puede estar vacío.");
        }
        if(string.IsNullOrWhiteSpace(codigoAlfaNumerico))
        {
            throw new ArgumentException("El código alfanumérico no puede estar vacío.");
        }
        if (stock < 0)
        {
            throw new ArgumentException("El stock no puede ser negativo.");
        }
        if (precioUnitario < 0)
        {
            throw new ArgumentException("El precio unitario no puede ser negativo.");
        }
        if (string.IsNullOrWhiteSpace(descripcion))
        {
            throw new ArgumentException("La descripción no puede estar vacía.");
        }
        
        Nombre = nombre;
        CodigoAlfaNumerico = codigoAlfaNumerico;
        Descripcion = descripcion;
        Stock = stock;
        PrecioUnitario = precioUnitario;
    }
}
